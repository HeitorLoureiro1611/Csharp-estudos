using System;
using System.Globalization;

namespace lists
{
    class Program
    {
        static void Main(String[] args)
        {
            var arr = new String[2];
            arr[0] = "primeiro item";
            arr[1] = "Segundo item";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(arr[i]);
            }

            var intarr = new List<int>();
            intarr.Add(1); 
            intarr.Add(2);
            
            foreach (int n in intarr)
            {
                Console.WriteLine(n);
            }
        }
    }
}