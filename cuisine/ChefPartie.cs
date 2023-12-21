namespace Cuisine;

public class ChefPartie
{
    private int id;
    private bool state;

    public ChefPartie(int id, bool state)
    {
        this.id = id;
        this.state = state;
    }

    public int getId()
    {
        return this.id;
    }

    public bool getState()
    {
        return this.state;
    }
    
    public int AssignCommis(List<CommisCuisine> commis)
    {
        int assignedCommisId = 0;

        Thread thread = new Thread(() =>
        {
            for (int i = 0; i < commis.Count; i++)
            {
                if (commis[i].getState()== true)
                {
                    assignedCommisId = commis[i].getId();
                    Console.WriteLine($"Commis with id '{assignedCommisId}' was assigned as state goes true");
                    break;
                }
            }
        });

        thread.Start();
        thread.Join(); // Attend la fin du thread avant de continuer l'exécution.

        return assignedCommisId;
        
    }
    public int AssignPlongeur(List<Plongeur> plongeurs)
    {
        int assignedPlongeurId = 0;

        Thread thread = new Thread(() =>
        {
            for (int i = 0; i < plongeurs.Count; i++)
            {
                if (plongeurs[i].getState()== true)
                {
                    assignedPlongeurId = plongeurs[i].getId();
                    break;
                }
            }
        });

        thread.Start();
        thread.Join(); // Attend la fin du thread avant de continuer l'exécution.

        return assignedPlongeurId;
        
    }

    public void prepare(int menuId, int etapes)
    {
        Thread thread = new Thread(() =>
        {
            for (int i=0; i<etapes; i++)    
            {   
                
                // insertion into database
            }
            
        });
        thread.Start();
        thread.Join();
    }
    
    
}