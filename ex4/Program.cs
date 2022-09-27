Console.WriteLine("enter amount of students");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("enter height of every student");
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter the {i + 1} -th students height between 150 and 200 cm");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 200 || array[i] < 150)
    {
        Console.WriteLine("error");
    }
}
Console.WriteLine("enter Petyas height");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 200 || x < 150)
{
    Console.WriteLine("error");
}

int temp;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
Console.WriteLine("check myself");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} , ");
}
int[] array1 = new int[n + 1];
for (int e = 0; e < n; e++)
{
    for (int i = 0; i < n; i++)
    {
        array1[e] = array[i];
    }
}
// na etom meste ya vstal
array1[n + 1] = x;
Console.WriteLine("check myself");
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"{array1[i]} , ");
}
