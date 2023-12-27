Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myMassive = new int[size];


myMassive = createMassive(myMassive, 0);
Console.WriteLine($"Массив:       [{String.Join(" ", myMassive)}]");
Console.WriteLine($"Новый массив: [{String.Join(" ", newMassive(myMassive, 0))}]");


//-------Выводим массив начиная с последнего элемента

int[] newMassive(int[] array, int i)
{
    int length = array.Length;
    if (i < (length / 2))
    {
        int temp = array[i];
        array[i] = array[(length - 1) - i];
        array[(length - 1) - i] = temp;
        i++;
        newMassive(array, i);
    }
    return array;

}


//-------Создаём массив заданного размера
int[] createMassive(int[] array, int i)
{
    array[i] = new Random().Next(1, 100);
    if (i < array.Length - 1)
    {
        i++;
        createMassive(array, i);
    }
    return array;

}



