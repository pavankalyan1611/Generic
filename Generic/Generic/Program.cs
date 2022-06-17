

namespace Generic
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to UC3 of  an array of Integer,Double and Character Print the same with Class Generic : ");
            Console.WriteLine();
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'p', 'a', 'v', 'a', 'n' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();



        }
    }
}
