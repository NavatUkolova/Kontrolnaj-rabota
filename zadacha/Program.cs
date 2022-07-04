// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами

void PrintArray(string [] array) // функция печати массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
}
string[] array = { "hello", "5", "world", ":-)" };

int j = 0;
int count = 0;

for ( int i = 0; i < array.Length; i++) // счетчик элементов в j
{
    if(array[i].Length <= 3)
    {
        j++;
    }
}
string[] array2 = new string [j];

for ( int i = 0; i < array.Length; i++) // заполнение массива array2
{
    if(array[i].Length <= 3)
    {
        array2[count] = array[i];
        count++;
    }
}

Console.Write("Изначальный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Массив с элементами от 3 и менее: ");
PrintArray(array2);



