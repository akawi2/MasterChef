namespace Cuisine.Controller;

public class KitchenController
{
    private ChefCuisine _chefCuisine;
    private List<ChefPartie> chefParties;
    private List<CommisCuisine> _commisCuisines;
    public KitchenController()
    {
        this._chefCuisine = new ChefCuisine();
        this.chefParties = new List<ChefPartie> { new ChefPartie(1, false), new ChefPartie(2,false) };
        this._commisCuisines = new List<CommisCuisine>{ new CommisCuisine(1, false), new CommisCuisine(2,false) };
    }

    public void initResto()
    {
     _chefCuisine.SendCommandToKitchen();   
    }

    public void assignChef()
    {
        foreach (var chefPartie in chefParties)
        {
            this._chefCuisine.AssignChefParie(chefParties);
        }
        
    }

    public void assignCommis()
    {
        foreach (var chefPartie in chefParties)
        {
            chefPartie.AssignCommis(_commisCuisines);
        }
        
    }
}