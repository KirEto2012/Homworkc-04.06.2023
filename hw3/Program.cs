/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.WriteLine("Ввидите чесло - A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Ввидите чесло - B: ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Натуральноя степинь:");

GetSumOfTwoNumbers(numA, numB);

void  GetSumOfTwoNumbers(int numberA, int numberB)
{
       int sum = 1;

    for (var i = 1; i <= numberB; i++)
    {
        //sum *= i;
        //Анологично
        sum = sum * numberA;
    }
    Console.WriteLine(sum);
}
