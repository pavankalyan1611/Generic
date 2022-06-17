

namespace Generic
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to UC2 of  an array of Integer,Double and Character Print the same with Generic : ");
            Console.WriteLine();
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5};
            char[] charArray = { 'p', 'a', 'v', 'a', 'n' };

            UC2_WithGeneric.toPrint<int>(intArray);
            UC2_WithGeneric.toPrint<double>(doubleArray);
            UC2_WithGeneric.toPrint<char>(charArray);


        }
    }
}