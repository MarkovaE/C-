//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int X = Convert.ToInt32(Console.ReadLine());
if (Convert.ToString(X)[0] == Convert.ToString(X)[4] && Convert.ToString(X)[1] == Convert.ToString(X)[3])
 Console.WriteLine("да/является палиндромом"); 
else 
{
    Console.WriteLine("нет/ не является палиндромом");
}