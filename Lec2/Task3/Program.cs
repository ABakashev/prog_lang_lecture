Console.WriteLine("Please, enter your number, which will represent length of an array");
int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] arr = new int[n];
int i = 0;

Console.WriteLine("Your array:");
while (i < n)
{
    arr[i] = rnd.Next(1, 10);
    Console.Write($"{arr[i]} ");
    i = i + 1;
}

i = 0;

Console.Write("\nYour answer:\n");
while (i < n)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}