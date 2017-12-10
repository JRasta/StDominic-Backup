using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myFirstString;

            Console.WriteLine("Hello World");
            
            //string myFirstString = createMeInCode();
            //Console.WriteLine("Hello " + myFirstString);



            Console.ReadLine();
        }

        static string createMeInCode()
        {
            string myName = "";

            Console.WriteLine("Please insert a name");
            myName = Console.ReadLine();

            return myName;
        }
    }
}
