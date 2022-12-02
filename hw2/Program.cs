//задайте массив одномерный, заполненный случайными числами, найдите сумму чисел, стоящих на нечетных позициях

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for(int i=0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}
    void ShowArray (int[] array)
{
    Console.Write("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


void FindSum (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine();
   Console.WriteLine(sum);
}


Console.WriteLine ("введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a,min,max);
ShowArray(myArray);
FindSum(myArray);
