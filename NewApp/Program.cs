using System;

int n;
do
{
    try
    {
        Console.WriteLine("n = ");
        n = Convert.ToInt16(Console.ReadLine());
    }
    catch
    {
        n = 0;
    }
} while (n < 1);

int[] A = new int[n];

for (int i = 0; i < A.Length; i++)
{
    Console.Write("A[{0}] = ", i);
    A[i] = Convert.ToInt16(Console.ReadLine());
}

for (int i = 0; i < A.Length; i++)
{
    Console.Write("{0}\t", A[i]);
}
