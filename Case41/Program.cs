// Пользователь вводит с клавиатуры М чисел. Посчитать, сколько чисел больше 0 ввел пользователь.
Console.WriteLine("Введите количество чисел, которые нужно сравнить: ");
int QuantityOfNumbers = int.Parse(Console.ReadLine());
int i = 0;
int count = 0;
string b = " ";
while (i < QuantityOfNumbers)
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    if (a > 0)
    {
        count = count + 1;
    }
    i ++;
    b = b + " " + a + ",";
}
Console.Write(b);
Console.Write("->" + count);
