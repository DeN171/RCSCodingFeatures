using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayHelloToUser();
            VardsGads();
        }


        static void SayHelloToUser()
        {
            Console.WriteLine("Ievadi savu vardu: ");
            string usersName;
            usersName = Console.ReadLine();
            Console.WriteLine("Labdien, " + usersName + "!");
            Console.ReadLine();
        }


        static void SayHello()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        static void VardsGads()
        {
            Console.WriteLine("Ievadi savu vardu: ");
            string usersName;
            string vecums;
            usersName = Console.ReadLine();
            Console.WriteLine("Labdien, " + usersName + "!");
            Console.WriteLine("Ievadi savu vecumu: ");           
            vecums = Console.ReadLine();
            Console.WriteLine("Tavs vecums: " + vecums);
            Console.ReadLine();
        }
    }
}
