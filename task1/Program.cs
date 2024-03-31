using System;


class Program
{
    static void PrintNumbersRecursively(int M, int N)
    {
        if (M > N) return;
        Console.WriteLine(M);
        PrintNumbersRecursively(M + 1, N);
    }


    static void Main()
    {
        PrintNumbersRecursively(2, 5);
    }
}
