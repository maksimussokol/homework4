Console.Clear();
Console.WriteLine("enter the numbers");
int[] array = new int[8];
for (int i = 0; i < 9; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = array.Length;
int position = 0;

while (position < count)
{
    Console.WriteLine(array[position]);
    position++;
}
