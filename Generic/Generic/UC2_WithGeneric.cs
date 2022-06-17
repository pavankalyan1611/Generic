using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
     class UC2_WithGeneric
     {
        public static void toPrint<P>(P[] inputArray)
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------------------");
        }
       
    }
}
