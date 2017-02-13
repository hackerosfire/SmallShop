using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            #region Sofia
            if (product == "coffee" && city == "Sofia")
            {
                Console.WriteLine(quantity * 0.5);
            }
            else if (product == "water" && city == "Sofia")
            {
                Console.WriteLine(quantity * 0.8);
            }
            else if (product == "beer" && city == "Sofia")
            {
                Console.WriteLine(quantity * 1.2);
            }
            else if (product == "sweets" && city == "Sofia")
            {
                Console.WriteLine(quantity * 1.45);
            }
            else if (product == "peanuts" && city == "Sofia")
            {
                Console.WriteLine(quantity * 1.6);
            }
            #endregion
            #region Plovdiv
            else if (product == "coffee" && city == "Plovdiv")
            {
                Console.WriteLine(quantity * 0.4);
            }
            else if (product == "water" && city == "Plovdiv")
            {
                Console.WriteLine(quantity * 0.7);
            }
            else if (product == "beer" && city == "Plovdiv")
            {
                Console.WriteLine(quantity * 1.15);
            }
            else if (product == "sweets" && city == "Plovdiv")
            {
                Console.WriteLine(quantity * 1.3);
            }
            else if (product == "peanuts" && city == "Plovdiv")
            {
                Console.WriteLine(quantity * 1.5);
            }
            #endregion
            #region Varna
            else if (product == "coffee" && city == "Varna")
            {
                Console.WriteLine(quantity * 0.45);
            }
            else if (product == "water" && city == "Varna")
            {
                Console.WriteLine(quantity * 0.7);
            }
            else if (product == "beer" && city == "Varna")
            {
                Console.WriteLine(quantity * 1.1);
            }
            else if (product == "sweets" && city == "Varna")
            {
                Console.WriteLine(quantity * 1.35);
            }
            else if (product == "peanuts" && city == "Varna")
            {
                Console.WriteLine(quantity * 1.55);
            }
#endregion
        }
    }
}
