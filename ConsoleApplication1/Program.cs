using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert array of integers into string, then concat string
            //int[] numArr = {0,1,2,3,4,5};
            //var variable = string.Join(",", numArr);

            //convert array on char to string, then concats string
            //char[] charArr = { 'a', 'b', 'c' };
            //var variable = new String(charArr);

            //chaining methods
            //char[] charArr = { 'a', 'b', 'c' };
            //var variable = new String(charArr).ToUpper();

            StringBuilder variable = new StringBuilder();

            variable.Append("Is this")
                .Append("really ")
                .Append("going to ")
                .Append("work")
                .Append("?!");
            Console.WriteLine("the string value: " + variable);
            Console.ReadKey();
        }
    }
}
