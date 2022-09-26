Console.Clear();
Console.WriteLine("enter the number");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < 1000; i++)
{
    int f = n % 10;
    n = n / 10;
    sum = sum + f;
}
Console.WriteLine(sum);