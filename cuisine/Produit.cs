namespace Cuisine;

public class Produit
{
    private int id;
    private string name;
    private bool state;
    private int quantity;

    public Produit(int quantity, int id, string name, bool state)
    {
        this.id = id;
        this.name = name;
        this.quantity = quantity;
        this.state = state;
    }
}