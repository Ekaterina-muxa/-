// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int[] CreateArray (int size)
{
    int [] newArray = new int [size];
    for(int i=0; i < size; i++)
    {
      Console.WriteLine ($"введите элемент {i}");
      newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray (int[] array)
{
    Console.Write ("получившийся массив - >");
    for (int i=0; i< array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }

}

void FindCount (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine();
   Console.WriteLine(count);
}

Console.Write("введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray (a);
ShowArray(myArray);
FindCount(myArray);