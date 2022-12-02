// задайте массив из целочисленных положительных трехзначных чисел
// напишите программу которая покажет количество четных чисел в массиве


int[] CreateArray (int size)
{
    int [] newArray = new int [size];
    for(int i=0; i < size; i++)
    {
      newArray[i] = new Random().Next(99,999);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    Console.Write ("получившийся массив - >");
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}
void FindCount (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0) count++;
    }
    Console.WriteLine();
   Console.WriteLine(count);
}
Console.WriteLine ("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[]newArray = CreateArray(size);
ShowArray(newArray);
FindCount(newArray);
