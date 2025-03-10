// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("mod1");
Console.WriteLine("mod2");
Console.WriteLine("mod3");

static void printAvg(int[] arr)
{
    float avg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        avg += arr[i];
    }
    avg /= arr.Length;
    Console.WriteLine("Average: " + avg);
}