/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

int length = Prompt("длина массива: ");
int min = Prompt("начяльное значение, для диапозона случайного числа: ");
int max = Prompt("Конечное значение, для диапозона случайного числа:");
int[] array = GenerateArray(length, min, max);
PrintArray(array);

// Ввод числа с экрана
int Prompt(string massage)
{
    System.Console.Write(massage);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

//метод для получения случайных значений массива

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int [Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");

}


