//example1 jagged array
using System;
class A
{
    public static void Main()
    {
        int[][] a = new int[5][];
        int i, j;
        a[0] = new int[7];
        a[1] = new int[3];
        a[2] = new int[10];
        a[3] = new int[2];
        a[4] = new int[5];

        for (i = 0; i < a.Length; i++)
        {
            for (j = 0; j < a[i].Length; j++)
            {
                Console.WriteLine("Enter Number");
                a[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\noutput:-");
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.Write("\n");
        }
        Console.ReadKey();
    }
}