Console.Clear();
Console.WriteLine("enter A number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter B number");
int b = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Math.Pow(a, b));
Console.WriteLine($"{a} v stepeni {b} = {f}");

