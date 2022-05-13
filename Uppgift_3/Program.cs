using System;
namespace Soda_application
{
    public class Soda_app
    {
        public string drink { get; set; }
        public string sugar { get; set; }
        public string antal { get; set; }

        public bool running {get; set;}
        static void Main(string[] args)
        {
            bool running = true;
            Cart new_cart = new Cart("Carl");
            Console.WriteLine("Welcome to the store");
            Console.WriteLine("Choose what to do");

            while(running = true){
                Console.WriteLine("(1) Add items");
                Console.WriteLine("(2) Remove items");
                Console.WriteLine("(3) Show Cart");
                Console.WriteLine("(4) Check out");
                string option = Console.ReadLine();
                if (option == "1"){
                    Console.WriteLine("Selection of drinks:");
                    new_cart.out_put_drinks();
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose type:");
                    string option_type = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("Sugar or Zero:");
                    string option_type_zero = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("16 (4x4), 24 (6x4), 36 (6x6)");
                    Console.WriteLine("Choose how many:");
                    string option_type_antal = Console.ReadLine();
                    Convert.ToInt16(option_type_antal);
                    new_cart.add_to_cart(option_type, option_type_zero, option_type_antal);

                }
                else if (option == "2"){

                }
                else if (option == "3"){
                    new_cart.print_list();
                }
                else if (option == "4"){

                }
                else{
                    Console.WriteLine("U are stuipd, choose a number please");
                    continue;
                }
            }
            new_cart.add_to_cart("Fant", "Zero", 12);
            new_cart.print_list();
        }

    }
}