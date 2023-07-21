List <int> numbers = new List <int>();
int x = 0;
Console.WriteLine("Введите три числа: ");
while (x < 3){
    numbers.Add(int.Parse(Console.ReadLine()));
    x++;
}
Console.WriteLine($"Число c максимальным значением: {numbers.Max()}");