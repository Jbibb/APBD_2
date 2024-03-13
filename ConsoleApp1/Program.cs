// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("#1 Hello, World!");
Console.WriteLine("#2 Hello, World!");
Console.WriteLine("#3 Hello, World!");

static double getAvg(int[] array)
{
    double res = 0;
    for (int i = 0; i < array.Length; i++)
        res += array[i];
    res /= array.Length;
    return res;
}