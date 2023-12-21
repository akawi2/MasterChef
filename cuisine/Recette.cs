namespace Cuisine;

public class Recette
{
    private int id;
    private string nom;
    private int price;
    private bool state;

    public Recette(int id, bool state, string nom, int price)
    {
        this.id = id;
        this.state = state;
        this.price = price;
        this.nom = nom;
    }
    
    
}