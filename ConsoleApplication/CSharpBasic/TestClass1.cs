using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestClass1
    {
        private int i = 0;

        public void SetVlaue(int value)
        {
            i = value;
        }


        public void GetVlaue()
        {
            Console.WriteLine("The vlaue of i is : " + i); 
        }

        public void TestCase1(string result)
        {
            Console.WriteLine("Execte test case 1 " +  result);
        }
        public void TestCase2(string result)
        {
            Console.WriteLine("Execte test case 2 " +  result);
        }

    }
}
