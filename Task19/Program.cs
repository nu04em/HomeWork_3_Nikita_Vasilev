// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Clear();

Console.Write("Введите пятизначное число: ");
string value = Console.ReadLine();
int num = int.Parse(value!);

while (num < 10000 || num > 99999)
    {
        Console.Write("Вы ввели не пятизначное число!\nВведите пятизначное число: ");
        value = Console.ReadLine();
        num = int.Parse(value!);
    }

int num1 = int.Parse(value.Remove(1));
int num2 = int.Parse(value.Remove(2)) % 10;
int num4 = int.Parse(value.Remove(4)) % 10;
int num5 = num % 10;

if (num1 == num5 && num2 == num4)
    Console.WriteLine("Число является палиндромом!");
else
    Console.WriteLine("Число не является палиндромом!");


// Console.WriteLine($"{num1}, {num2}, {num4}, {num5}");



// Console.WriteLine(int.Parse(value.Remove(2)) % 10);
// return;
