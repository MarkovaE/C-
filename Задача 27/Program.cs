//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
while (A != 0)
      {
        sum += A % 10;
        A /= 10;
      }

Console.WriteLine(sum);