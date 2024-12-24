using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Lyrics();
            Console.WriteLine("-------------------------------------");
            int mod = RandomNumberAndMod();
            Console.WriteLine($"Rastgele sayinin 2'ye bolümünden kalan {mod}");
            Console.WriteLine("-------------------------------------");
            int multiply = Multiply(5, 6);
            Console.WriteLine($"5 ile 6'nin carpimi {multiply}");
            Console.WriteLine("-------------------------------------");
            Print("Furkan", "Cengiz");

        }
        public static void Lyrics()
        {
            Console.WriteLine("Obie Trice, real name, no gimmicks\r\nRa—\r\nTwo trailer-park girls go round the outside\r\nRound the outside, round the outside\r\nTwo trailer-park girls go round the outside\r\nRound the outside, round the outside\r\nWoo (Ooh, ooh)");
            
        }

       public  static int RandomNumberAndMod()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            int mod = randomNumber % 2;
            return mod;
        }

        public static int Multiply(int a ,int b) 
        {

            return a * b;

        
        }

        public static void Print(string name , string lastname)
        {
            Console.WriteLine($"Hos Geldiniz {name} , {lastname} ");
        }

    }
}
