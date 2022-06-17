using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
     public class PrintArray<P>
     {
        private P[] inputArray;

        public PrintArray(P[] inputArray)
        {
            this.inputArray = inputArray;
        }


        public void toPrint()
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------------------");
        }
       
    }
}
