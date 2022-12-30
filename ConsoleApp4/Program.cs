using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "joy";
            int age = 58;
            Console.WriteLine(name + age);
            Hero vijay = new Hero();
            Console.WriteLine(vijay.number);
            vijay.setNumber(9999999);
            Console.WriteLine(vijay.number);
            Value eql = new Value();
            Console.WriteLine(eql.bal);
            eql.setBal(890);
            Console.WriteLine(eql.bal);
            Console.ReadLine();

        }
    }
}
