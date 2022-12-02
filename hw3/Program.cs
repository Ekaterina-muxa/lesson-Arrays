// задайте массив вещественных чисел. найдите разницу между минимальным и максимальным элементом массива

int[] CreateArray (int size)
{
    int [] newArray = new int [size];
    for(int i=0; i < size; i++)
    {
      newArray[i] = new Random().Next(1,100);
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

void FindDiff (int [] array)
{
    int arrayMax = array[0];
    int arrayMin = array[0];
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] > arrayMax) 
        {
            arrayMax = array[i];
        }
        if (array[i] < arrayMin)
        {
          arrayMin = array[i];  
        }
        
    }

    int result = (arrayMax - arrayMin);
    Console.WriteLine(result);
}

Console.WriteLine ("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[]newArray = CreateArray(size);
ShowArray(newArray);
FindDiff(newArray);