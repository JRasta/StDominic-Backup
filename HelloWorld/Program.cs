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
            /*  
                int myFirstInt;
                double myFirstDouble;
                bool myFirstBook = true;
                var myFirstVar;
                string myFirstString = createMeInCode();
                Console.WriteLine("Hello " + myFirstString);
                
            */


            Console.WriteLine("Hello World");
            //ReadLine is to stop the program terminating until a key is pressed in the console
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
