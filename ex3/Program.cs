Console.Clear();
Console.WriteLine("enter the numbers");
int[] array = new int[8];
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]}, ");
}
array[7] = new Random().Next(1, 100);
Console.Write(array[7]);
Console.WriteLine("]");
// boje moi kakoi pizdec kak je krivo ya eto napisal....no ono rabotaet