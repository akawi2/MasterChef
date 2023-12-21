namespace Cuisine;

public class Ustensile
{
    private int id;
    private int quantity;
    private string name;
    private bool state;

    public Ustensile(int id, bool state, int quantity, string name)
    {
        this.id = id;
        this.state = state;
        this.name = name;
        this.quantity = quantity;   
    }
}