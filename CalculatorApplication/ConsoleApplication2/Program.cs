using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Aakash";
            lname = "Deolekar";
            string fullname = fname + lname;
            Console.WriteLine("FullName : {0}", fullname);

            char[] teststring = new char[2] { 'A', 'B' };
            string greeting = "Hello ";
            
            Console.WriteLine("Greetings: {0}, {1}", greeting,fullname);
            Console.ReadLine();
        }
    }
}
