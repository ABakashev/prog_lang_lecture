Console.WriteLine("Please, enter your number, which will represent length of an array");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    // Console.WriteLine(arr[i] + " ");
    Console.Write($"{arr[i]} ");
    i = i + 1;
}