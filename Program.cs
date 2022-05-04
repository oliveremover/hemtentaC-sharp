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
            string size_choosen = Console.ReadLine();
            Console.WriteLine("What standard with the size:");
            if (size_choosen == "1"){
                One();
            }
            else if (size_choosen == "2"){
                Two();
            }
            else if (size_choosen == "3"){
                Three();
            }
            else if (size_choosen == "4"){
                Four();
            }
            else {
                Error();
            }
        } 
        
        void Choose_sizes(){
            Console.WriteLine("Begin by choosing size!");
            Console.WriteLine(" ");
            Console.WriteLine("Sizes avalible: (ony number)");
            Console.WriteLine(string.Join(" : ", obj.sizes)); 
            
        }
        void One(){
            obj.standard[1] = "1 window";
            Console.WriteLine("The standard:");
            Console.WriteLine(string.Join(" : ", obj.standard));   
        }
        void Two(){
            obj.standard[1] = "2 window";
            Console.WriteLine("The standard:");
            Console.WriteLine(string.Join(" : ", obj.standard));
            Console.WriteLine("Uniqe:");
            Console.WriteLine(obj.standard[0]);
        }
        void Three(){
            obj.standard[1] = "4 window";
            Console.WriteLine("The standard:");
            Console.WriteLine(string.Join(" : ", obj.standard));   
            Console.WriteLine("Uniqe:");
            Console.WriteLine(obj.standard[0]," : ", obj.standard[2]);
        }
        void Four(){
            obj.standard[1] = "6 window";
            Console.WriteLine("The standard:");
            Console.WriteLine(string.Join(" : ", obj.standard));   
            Console.WriteLine("Uniqe:");
            Console.WriteLine(string.Join(" : ", obj.uniqe));  
        } 
        void Error(){
            Console.WriteLine("Input not acceptable");
            Start();
        }
    
    }
}