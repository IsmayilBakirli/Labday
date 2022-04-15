using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newgunapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
       static void Menu()
       {
            string input = Console.ReadLine();
            switch (input)
            {
                case "a";
                    Console.WriteLine("bu herf a-di");
                    break;
                case "b";
                    Console.WriteLine("bu herf b-di");
                    break;                 
            }
                
       }
    }
}
