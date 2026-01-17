using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array = { 12, 23, -22, -765, 43, 545, -4, -55, 43, 12, 351, -999, -87 };

        List<int> nrPozitive = new List<int>();
        List<int> nrNegative = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                nrPozitive.Add(array[i]);
            }
            else if (array[i] < 0) { 
                nrNegative.Add(array[i]);
            }
        }

        Console.WriteLine("Numere pozitive: ");
        foreach (int num in nrPozitive)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n\nNumere negative: ");
        foreach(int num in nrNegative)
        {
            Console.Write(num + " ");
        }
    }
}