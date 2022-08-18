// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Exponentiation(int number, int degreeOfNumber)
{
  int result = 1;
    for(int i=1; i <= degreeOfNumber; i++)
    {
        result = result * number;
    }
        return result;
}

Console.Clear();

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int degreeOfNumber = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(number, degreeOfNumber);
  Console.WriteLine($"Число {number} в степени {degreeOfNumber} равно " + exponentiation);




