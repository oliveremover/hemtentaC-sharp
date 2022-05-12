using System.Linq;
namespace Soda_application
{
public class Soda
{
    // Static field currentID stores the job ID of the last WorkItem that
    // has been created.
    private static int currentID;

    protected List<string> youre_cart_mutherfucker = new List<string>();
    protected List<string> sodas = new List<string>();
    //Properties.
    protected int ID { get; set; }
    protected string Type_of_drink { get; set; }
    protected string Zero_or_not { get; set; }
    protected int Antal { get; set; }

    // Default constructor. If a derived class does not invoke a base-
    // class constructor explicitly, the default constructor is called
    // implicitly.
    public Soda()
    {
        ID = 0;
        Type_of_drink = "Drink type";
        Zero_or_not = "Shit or Hit";
        Antal = 0;
    }

    // Instance constructor that has three parameters.
    public Soda(string type_of_drink, string zero_or_not, int antal)
    {
        this.ID = GetNextID();
        this.Type_of_drink = type_of_drink;
        this.Zero_or_not = zero_or_not;
        this.Antal = antal;
    }

    // Static constructor to initialize the static member, currentID. This
    // constructor is called one time, automatically, before any instance
    // of WorkItem or ChangeRequest is created, or currentID is referenced.
    static Soda() => currentID = 0;

    // currentID is a static field. It is incremented each time a new
    // instance of WorkItem is created.
    protected int GetNextID() => ++currentID;

    // Method Update enables you to update seats to take
    public override string ToString() =>
        $"{this.ID} - {this.Type_of_drink} - {this.Zero_or_not} - {this.Antal}";
}
}
