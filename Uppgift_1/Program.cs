using System;
namespace Apartment_application
{
    /// <summary>
    /// Creates an object of Choices().
    /// Object is then called with Start().
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Choices obj1 = new Choices();
            obj1.Start();


        }
    }
    public class Choices
    {
        Apartment_complex obj = new Apartment_complex();

        /// <summary>
        /// Contains the steps where the user interacts in the termninal. 
        /// </summary>
        public void Start(){
            obj.viewer_have_choosen.Clear();
            Console.WriteLine("Choose your destiny!");
            Choose_sizes();
            string size_choosen = Console.ReadLine();
            Console.WriteLine("What comes with the apartment");
            if (size_choosen == "1"){
                One();
                Choose_additional();
                Choose_kitchen_island();
                Print_dict();
            }
            else if (size_choosen == "2"){
                Two();
                Choose_additional();
                Choose_kitchen_island();
                Print_dict();
            }
            else if (size_choosen == "3"){
                Three();
                Choose_additional();
                Choose_kitchen_island();
                Print_dict();
            }
            else if (size_choosen == "4"){
                Four();
                Choose_additional();
                Choose_kitchen_island();
                Print_dict();
            }
            else {
                Error();
            }
        } 
        /// <summary>
        /// Gives the user the options avalible.
        /// </summary>
        void Choose_sizes(){
            Console.WriteLine(" ");
            Console.WriteLine("Begin by choosing size!");
            Console.WriteLine(" ");
            Console.WriteLine("Sizes avalible: (ony number)");
            Console.WriteLine(string.Join(" : ", obj.sizes)); 
            for (int i = 0; i < obj.standard.Length; i++){
                obj.viewer_have_choosen.Add(obj.standard[i], "True");
            }
        }
        /// <summary>
        /// Gives the user the extra options that comes with the choosen size.
        /// </summary>
        void Choose_additional(){
            Console.WriteLine(" ");
            Console.WriteLine("Add extra:");
            Console.WriteLine("Extra avalible: (name, if more use space between)");
            Console.WriteLine(string.Join(" : ", obj.additional));
            string split;
            split = Console.ReadLine();
            List<string> pre_list = new List<string>();
            pre_list = split.Split(',').ToList();
            foreach(var l in pre_list)
            {
                    if (obj.additional.Any(l.Contains)){
                        Console.WriteLine(l);
                        obj.viewer_have_choosen.Add(l, "True");
                    }
                
            }
        }
        /// <summary>
        /// Gives the option of what type of kitchen islands avalible and adds the choosen one to the dictonary in Apartment_complex.
        /// </summary>
        void Choose_kitchen_island(){
            Console.WriteLine(" ");
            Console.WriteLine("Choose kitchen island");
            Console.WriteLine(string.Join(" : ", obj.kitchen_island_type));
            string type;
            type = Console.ReadLine();
            if (obj.kitchen_island_type.Any(type.Contains)){
                obj.viewer_have_choosen.Add(type, "True");
            }
        }
        /// <summary>
        /// Print out what the 1 room apartment comes with.
        /// </summary>
        void One(){
            Console.WriteLine(" ");
            obj.standard[1] = "1 window";
            Console.WriteLine("The standard:");
            Console.WriteLine(string.Join(" : ", obj.standard));   
        }
        /// <summary>
        /// Print out what the 2 room apartment comes with.
        /// </summary>
        void Two(){
            Console.WriteLine(" ");
            obj.standard[1] = "2 window";
            Console.WriteLine("The standard:");
            Console.WriteLine(string.Join(" : ", obj.standard));
            Console.WriteLine("Uniqe:");
            Console.WriteLine(obj.uniqe[0]);
        }
        /// <summary>
        /// Print out what the 3 room apartment comes with.
        /// </summary>
        void Three(){
            Console.WriteLine(" ");
            obj.standard[1] = "4 window";
            Console.WriteLine("The standard:");
            Console.WriteLine(string.Join(" : ", obj.standard));   
            Console.WriteLine("Uniqe:");
            Console.WriteLine(obj.uniqe[0]," : ", obj.uniqe[2]);
            obj.viewer_have_choosen.Add(obj.uniqe[0], "True");
            obj.viewer_have_choosen.Add(obj.uniqe[2], "True");
        }
       /// <summary>
        /// Print out what the 4 room apartment comes with.
        /// </summary>
        void Four(){
            Console.WriteLine(" ");
            obj.standard[1] = "6 window";
            Console.WriteLine("The standard:");
            Console.WriteLine(string.Join(" : ", obj.standard));   
            Console.WriteLine("Uniqe:");
            Console.WriteLine(string.Join(" : ", obj.uniqe));  
            for (int i = 0; i < obj.uniqe.Length; i++){
                obj.viewer_have_choosen.Add(obj.uniqe[i], "True");
            }
        } 
        /// <summary>
        /// If error occur, Error() is called and restarts the program.
        /// </summary>
        void Error(){
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Input not acceptable");
            Start();
        }
        /// <summary>
        /// Prints out the data from the Dictonary with the options the user has choosen.
        /// </summary>
        void Print_dict(){
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Here is what is included");
            foreach (KeyValuePair<string, string> kv in obj.viewer_have_choosen)
                Console.WriteLine(kv.Key.ToString());
        }
    
    }
}