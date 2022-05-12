using System;
namespace Soda_application
{
    public class Soda_app
    {
        static void Main(string[] args)
        {
            Soda newSoda_order = new Soda("Cola", "Zero", 36);
            Console.WriteLine(newSoda_order.ToString());
        }

    }
}