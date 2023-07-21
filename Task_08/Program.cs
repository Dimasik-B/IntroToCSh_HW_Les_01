Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 2;
string result = null;
while (count <= number){
    result += (count % 2 == 0 ? count.ToString() : ", ");
    count++;
}
if (number % 2 != 0) Console.WriteLine(result.Remove(result.Length - 2));
else Console.WriteLine(result);

