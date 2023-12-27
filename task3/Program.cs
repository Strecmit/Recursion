Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myMassive = new int[size];


//-------
int[] createMassive(int[] array, int i)
{
    array[i] = new Random().Next(1,100);
    if(i < array.Length){
        i++;
        createMassive(array, i);
    }
    else {return array;}

}

myMassive = createMassive(myMassive, 0);
Console.Write(myMassive);


