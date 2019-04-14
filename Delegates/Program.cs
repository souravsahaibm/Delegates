using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void HelloFunc(string msg);
    class Program
    {
        private static void Main(string[] args)
        {
            HelloFunc del = new HelloFunc(Hello);
            del("I am Sourav Saha");
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
