// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double B = Convert.ToInt32(Console.ReadLine());
double Result = 0;
for (int i = 1; i < B; i++);
Result = Math.Pow(A, B);
Console.WriteLine(Result);