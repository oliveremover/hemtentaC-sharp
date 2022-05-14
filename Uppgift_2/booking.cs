using System.Linq;
namespace Cinema_application
{
    /// <summary>
    /// Creates movies and keep tracks of seating.
    /// </summary>
    public class Movies
    {
        // Static field currentID stores the ID of the last Movie that has been created.
        private static int currentID;

        protected List<string> seats_map = new List<string>();

        protected List<string> seats_reserved = new List<string>();
        protected List<string> seats_avalible = new List<string>();
        //Properties.
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected int MovieLength { get; set; }
        protected string Row { get; set; }
        protected string Seat{ get; set; }

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
        // of Movies or currentID is referenced.
        static Movies() => currentID = 0;

        // currentID is a static field. It is incremented each time a new
        // instance of WorkItem is created.
        protected int GetNextID() => ++currentID;

        /// <summary>
        /// Method Update_seat() enables you to update seats to Occupied
        /// </summary>
        /// <param name="row">Contains user choose of row</param>
        /// <param name="seat">Contains user choose of seats</param>
        public void Update_seat(string row, string seat)
        {
            this.Row = row;
            this.Seat = seat;
            string[] splitted = seat.Split(" ");
            for(int i = 0; i < splitted.Length; i++){
                string value = "Row " + row + " : " + splitted[i];
                Console.WriteLine(value);
                if(seats_map.Contains(value)){
                    int idx = seats_map.IndexOf(value);
                    seats_map[idx] = "Occupied";
                    tickets_are_booked();
                }
                else {
                    Console.WriteLine("These seats are taken");
                }
            }
        }
        /// <summary>
        /// Prints out statement.
        /// </summary>
        public void tickets_are_booked(){
            Console.WriteLine("You're tickets are booked");
        }
        /// <summary>
        /// Uses loops to add seats to seats_map
        /// </summary>
        public void create_seat_map(){
            for(int i = 1; i <= 15; i++){
                object value = "Row 1 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 2 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 3 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 4 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 5 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 6 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 7 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 8 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 9 : " + i;
                seats_map.Add(value.ToString());
            }
            for(int i = 1; i <= 15; i++){
                object value = "Row 10 : " + i;
                seats_map.Add(value.ToString());
            }
        }
        /// <summary>
        /// Shows the seats avalible.
        /// </summary>
        public void show_seat_map()
            {
            for(int i = 0; i < seats_map.Count; i++){
                Console.WriteLine(seats_map[i]);
            }
        }
        // Virtual method override of the ToString method
        public override string ToString() =>
            $"{this.ID} - {this.Title}";
    }
}
