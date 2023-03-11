void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int index = 0;
    int length = collection.Length;
    while (index < length)
    {
        Console.Write(collection[index]);
        Console.Write(", ");
        index++;
    }
}
void MaxArray(int[] mas, int FindX)
{
    int index = 0;
    int length = mas.Length;
    int Maximum = mas[0];
    while (index < length)
    {
        if (mas[index] > Maximum)
        {
            Maximum = mas[index];
        }
        if (FindX == mas[index])
        {
            Console.WriteLine($"Позиция в массиве: {index}");
        }
        index++;
    }
Console.WriteLine($"Максимальный элемент: {Maximum}"); 
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
MaxArray(array, 3);

