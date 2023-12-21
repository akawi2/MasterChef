using System.Net;
using System.Net.Sockets;
using System.Text;
using ClassLibrary1;

namespace Cuisine;

public class ChefCuisine
{
    private int id;
    private bool state;

    public ChefCuisine(int id, bool state)
    {
        this.id = id;
        this.state = state;
    }
    public ChefCuisine()
    {
 
    }

    
    private const int Port = 8080;  

    public void SendCommandToKitchen()
    {
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, Port);

        try
        {
            // Create a TCP/IP socket
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections
            listener.Bind(localEndPoint);
            listener.Listen(10);

            // Accept incoming connections
            Socket clientSocket = listener.Accept();

            // Receive data from the client
            byte[] buffer = new byte[1024];
            int bytesRead = clientSocket.Receive(buffer);
            string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            // Send a response back to the client
            string responseMessage = "Hello from the server!";
            byte[] responseBytes = Encoding.ASCII.GetBytes(responseMessage);
            clientSocket.Send(responseBytes);

            // Close the connection
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
    
    public int AssignChefParie(List<ChefPartie> chefParties)
    {
        int assignedChefPartie = 0;

        Thread thread = new Thread(() =>
        {
            for (int i = 0; i < chefParties.Count; i++)
            {
                if (chefParties[i].getState() == true)
                {
                    assignedChefPartie = chefParties[i].getId();
                    Console.WriteLine($"chef de partie with id of '{assignedChefPartie}' was assigned");
                    LogWriter logWrite = new LogWriter("C:\\Users\\GLC\\RiderProjects\\TestchiefMaster\\Restaurant\\log.txt");
                    logWrite.WriteLog($"chef de partie with id of '{assignedChefPartie}' was assigned");
                    break;
                }
            }
        });

        thread.Start();
        thread.Join(); // Attend la fin du thread avant de continuer l'exécution.

        return assignedChefPartie;
    }
    
}