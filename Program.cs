﻿using System;
namespace Apartment_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Apartment_complex myObj = new Apartment_complex();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.full);
        }
    }
}