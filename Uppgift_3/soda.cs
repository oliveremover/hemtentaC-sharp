using System.Linq;
namespace Soda_application
{
public class Soda : Cart
{
    private static int currentID;
    // Static field currentID stores the job ID of the last WorkItem that
    // has been created.
    //protected List<Drink> youre_cart_mutherfucker = new List<Drink>();
    public int ID { get; set; }
    //Properties.
    public string Type_of_drink { get; set; }
    public string Zero_or_not { get; set; }
    public int Antal { get; set; }

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
    // of Soda or currentID is referenced.
    static Soda() => currentID = 0;

    // currentID is a static field. It is incremented each time a new
    // instance of Soda is created.
    protected int GetNextID() => ++currentID;

    // Virtual method override of the ToString method
    public override string ToString() =>
        $"{this.ID} - {this.Type_of_drink} - {this.Zero_or_not} - {this.Antal}";
}


    /// <summary>
    /// Creates and stores the shopping cart of user. Also contains the method to change in the cart.
    /// </summary>
    public class Cart {
        protected List<Soda> the_cart = new List<Soda>();
        protected List<int> total_cost = new List<int>();
        protected List<string> sodas = new List<string>();
        public String Name { get; set; }
        public Cart()
        {
            Name = "Name";
        }
        public Cart(string name){
            this.Name = name;
            
        }
        /// <summary>
        /// Adds Soda to cart. Also adds the cost 
        /// </summary>
        /// <param name="name_of_drink"></param>
        /// <param name="sugar"></param>
        /// <param name="many"></param>
        public void add_to_cart(string name_of_drink, string sugar, int many){
            the_cart.Add(new Soda() { Type_of_drink = name_of_drink, Zero_or_not=sugar, Antal=many});
            total_cost.Add(many * 10);

        }
        public void print_list(){
            for (int i = 0; i < the_cart.Count(); i++){
                Console.WriteLine(the_cart[i]);
            }
        }
        /// <summary>
        /// Removes the item user choose.
        /// </summary>
        /// <param name="item_to_remove">The item user inputed.</param>
        public void remove_item(string item_to_remove){
            
        }
        /// <summary>
        /// Prints out the total cost of the cart.
        /// </summary>
        public void total_cost_of_cart(){
            int result = total_cost.Sum();
            Console.WriteLine(result + " kr");
        }
        /// <summary>
        /// Adds all the drinks in the selection.
        /// </summary>
        public void input_drinks_to_list(){
            sodas.Add("Cola");
            sodas.Add("Pepsi");
            sodas.Add("Sprite");
            sodas.Add("7Up");
            sodas.Add("Jarritos");
            sodas.Add("Fanta lemon");
            sodas.Add("Fanta tropical");
            sodas.Add("Fanta Orange");
        }
        /// <summary>
        /// Prints out all the drinks in sodas list.
        /// </summary>
        public void out_put_drinks(){
            for(int i = 0; i < sodas.Count; i++){
                Console.WriteLine(sodas[i]);
            }
        }

    }

    
}
