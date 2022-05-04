using System;
namespace Apartment_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Choices obj1 = new Choices();
            obj1.Start();


        }
    }
    public class Choices
    {
        Apartment_complex obj = new Apartment_complex();

        
        public void Start(){
            Console.WriteLine("Choose your destiny!");
            Choose_sizes();
            string size_choosen = Console.ReadLine("");
            if (size_choosen == "1"){

            }
            else if (size_choosen == "2"){

            }
            else if (size_choosen == "3"){
                
            }
            else if (size_choosen == "4"){
                
            }
            else {
                Error();
            }
        } 
        void Choose_sizes(){
            Console.WriteLine("Begin by choosing size!");
            Console.WriteLine(" ");
            Console.WriteLine("Sizes avalible: (ony number)");
            Console.WriteLine(string.Join(" ", obj.sizes)); 
            
        }
        void Bark(){
            Console.WriteLine(obj.sizes);   
        } 
        void Error(){
            Console.WriteLine("Input not acceptable");
            Start();
        }
    
    }
}