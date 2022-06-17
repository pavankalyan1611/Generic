

namespace Generic
{
    class Program
    {
        public static void Main(string[] arg)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };
            char[] charArray = { 'p', 'a', 'v', 'a', 'n' };

            UC1_WithoutGeneric.toPrint(intArray);
            UC1_WithoutGeneric.toPrint(doubleArray);
            UC1_WithoutGeneric.toPrint(charArray);


        }
    }
}