namespace Cuisine;

public class CommisCuisine
{
    private int id;
    private bool state;

    public CommisCuisine(int id, bool state)
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