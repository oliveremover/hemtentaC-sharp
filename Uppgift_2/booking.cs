using System.Linq;
namespace Cinema_application
{
public class Movies
{
    // Static field currentID stores the job ID of the last WorkItem that
    // has been created.
    private static int currentID;

    protected List<string> seats_map = new List<string>();

    protected List<string> seats_taken = new List<string>();
    //Properties.
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected int MovieLength { get; set; }
    protected string Row { get; set; }
    protected int Seat{ get; set; }
    protected string Number_of_tickets{ get; set; }

    // Default constructor. If a derived class does not invoke a base-
    // class constructor explicitly, the default constructor is called
    // implicitly.
    public Movies()
    {
        ID = 0;
        Title = "Default title";
        Description = "Default description.";
        MovieLength = 0;
    }

    // Instance constructor that has three parameters.
    public Movies(string title, string desc, int movielen)
    {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = desc;
        this.MovieLength = movielen;
    }

    // Static constructor to initialize the static member, currentID. This
    // constructor is called one time, automatically, before any instance
    // of WorkItem or ChangeRequest is created, or currentID is referenced.
    static Movies() => currentID = 0;

    // currentID is a static field. It is incremented each time a new
    // instance of WorkItem is created.
    protected int GetNextID() => ++currentID;

    // Method Update enables you to update the title and job length of an
    // existing WorkItem object.
    public void Update_seat(string row, int seat)
    {
        this.Row = row;
        this.Seat = seat;

        object value = row + " : " + seat;
        for(int i = 0; i < seats_map.Count; i++){
            if(seats_map[i] == value.ToString()){
                seats_map[i] = "Occupied";
            }
        }
    }

    public void create_seat_map(){
        for(int i = 0; i <= 15; i++){
            object value = "Row 1 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 2 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 3 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 4 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 5 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 6 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 7 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 8 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 9 : " + i;
            seats_map.Add(value.ToString());
        }
        for(int i = 0; i <= 15; i++){
            object value = "Row 10 : " + i;
            seats_map.Add(value.ToString());
        }
    }
    public void show_seat_map(string number_of_tickets)
        {
        for(int i = 0; i < seats_map.Count;i++){
            if (seats_map[i] == "Occupied"){

            }
            else{
                if(seats_map.Where(s=>s!=null && s.StartsWith("S")).Count()){
                    
                }
                Console.WriteLine(seats_map[i]);
            }
        }
    }

    // Virtual method override of the ToString method that is inherited
    // from System.Object.
    public override string ToString() =>
        $"{this.ID} - {this.Title}";
}

// ChangeRequest derives from WorkItem and adds a property (originalItemID)
// and two constructors.
public class Book_seats : Movies
{
    // Constructors. Because neither constructor calls a base-class
    // constructor explicitly, the default constructor in the base class
    // is called implicitly. The base class must contain a default
    // constructor.

    // Default constructor for the derived class.
    public Book_seats() { }

    // Instance constructor that has four parameters.
    public Book_seats(string row, int seat,
                         int originalID)
    {
        // The following properties and the GetNexID method are inherited
        // from WorkItem.
        this.ID = GetNextID();
        this.Row = row;
        this.Seat = seat;

        // Property originalItemId is a member of ChangeRequest, but not
        // of WorkItem.
    }
}
}