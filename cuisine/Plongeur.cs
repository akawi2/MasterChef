namespace Cuisine;

public class Plongeur
{
    private int id;
    private bool state;

    public Plongeur(int id, bool state)
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
}