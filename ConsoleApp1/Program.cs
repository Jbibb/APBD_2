// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("#1 Hello, World!");
Console.WriteLine("#2 Hello, World!");
Console.WriteLine("#3 Hello, World!");

static double getAvg(int[] array)
{
    double result = 0;
    for (int i = 0; i < array.Length; i++)
        result += array[i];
    result /= array.Length;
    return result;
}

static double getMax(int[] array)
{
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}