/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Ввидите чесло: ");
int numA = int.Parse(Console.ReadLine());
int sum = GetSumOfTwoNumbers(numA);
Console.WriteLine(sum);

int GetSumOfTwoNumbers(int numberA)
{
    int sum = 0;
    while (numberA > 0)
    {
        sum += numberA %10;
        numberA = numberA /10;
    
    }
    return sum;
}

