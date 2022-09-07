int Day = Convert.ToInt32(Console.ReadLine());
int Max = 7;
if (Day == 6||Day == 7)
Console.WriteLine("да");
if (Day == 1||Day == 2||Day == 3||Day == 4||Day == 5)
Console.WriteLine("нет");
if (Day >Max)
Console.WriteLine("Введите число от 1 до 7: ");