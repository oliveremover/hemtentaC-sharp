using System;
namespace Soda_application
{
    public class Soda_app
    {
        public string drink { get; set; }
        public string sugar { get; set; }
        public string antal { get; set; }

        static void Main(string[] args)
        {
            bool running = true;
            Cart new_cart = new Cart("Carl");
            Console.WriteLine("Welcome to the store");
            Console.WriteLine("Choose what to do");
            new_cart.input_drinks_to_list();
            while(running = true){
                Console.WriteLine("(1) Add items");
                Console.WriteLine("(2) Remove items");
                Console.WriteLine("(3) Show Cart");
                Console.WriteLine("(4) Check out");
                Console.WriteLine("(5) Close application");
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
                    Console.WriteLine("16 (I 4x4 back), 24 (I 6x4 back), 36 (I 6x6 back)");
                    Console.WriteLine("Choose how many:");
                    int option_type_antal = Convert.ToInt32(Console.ReadLine());
                    if (new_cart.sodas.Contains())
                    new_cart.add_to_cart(option_type, option_type_zero, option_type_antal);
                    Console.WriteLine(" ");
                    Console.WriteLine("Item added");

                }
                else if (option == "2"){
                    Console.WriteLine(" ");
                    new_cart.print_list();
                    Console.WriteLine(" ");
                    Console.WriteLine("What Item do you want to remove:");
                    string item_to_remove = Console.ReadLine();
                    new_cart.remove_item(item_to_remove);
                }
                else if (option == "3"){
                    Console.WriteLine("Your Cart:");
                    new_cart.print_list();
                }
                else if (option == "4"){
                    Console.WriteLine("Your Total:");
                    new_cart.total_cost_of_cart();
                    Console.WriteLine(" ");
                    Console.WriteLine("Proceding payment...");
                    Console.WriteLine("Opening SWISH...");
                    break;
                }
                else if (option == "5"){
                    break;
                }
                else{
                    Console.WriteLine("U are stuipd, choose a number please");
                    continue;
                }
            }
        }

    }
}