using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeektasticCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter A, B, C or D to add an item to your basket.");
            Console.WriteLine("Press Enter to finish and receive the total: \n");
            string keysEntered = "";
            keysEntered = Console.ReadLine();
            Checkout checkout = new Checkout(keysEntered);
            Console.WriteLine($"£{checkout.CalculateTotal()}");
            Console.Read();
        }
    }
}
