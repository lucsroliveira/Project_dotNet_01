using System;
using src.Entities; 
namespace _Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.attack());
            Console.Write(wizard.attack());
        } 
    }   
}
