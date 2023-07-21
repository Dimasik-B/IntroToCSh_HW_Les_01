Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string result = (number % 2 == 0 ? "чётное" : "нечётное");
Console.Write($"{number} - {result} число");