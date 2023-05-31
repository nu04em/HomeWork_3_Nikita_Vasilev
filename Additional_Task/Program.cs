// Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – 
// количество кустов черники. Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – 
// число ягод черники, растущее на соответствующем кусте. Все ai не превосходят 1000.
// Модуль может убирать ягоды сразу с 3 кустов
// Число ягод на каждом кусте отличается, но не больше 1000 шт. на каждом кусте

Console.Clear();

Console.Write("Введите какое количество кустов находится на грядке: ");
int kustCount = int.Parse(Console.ReadLine()!);

while (kustCount < 3 || kustCount > 1000)
    {
        Console.WriteLine("Количество кустов не может быть меньше 3 и больше 1000!\n Введите какое количество кустов находится на грядке (от 3 до 1000):");
        kustCount = int.Parse(Console.ReadLine()!);
    }

int[] chernikaOnKusts = new int[kustCount];

for (int i = 0; i < kustCount; i++)
    {
        chernikaOnKusts[i] = new Random().Next(1, 1001);
        Console.WriteLine($"Количество ягод на {i + 1} кусте: {chernikaOnKusts[i]}");   
    }

int maxSum = 0;

for (int i = 0; i < chernikaOnKusts.Length; i++)
    {
        int currentKust = chernikaOnKusts[i];
        int nextKust = 0;
        int prevKust = 0;

        if (i == 0)
            {
                prevKust = chernikaOnKusts[chernikaOnKusts.Length - 1];
                nextKust = chernikaOnKusts[i + 1];
            }
        else if (i == chernikaOnKusts.Length - 1)
        {
            nextKust = chernikaOnKusts[0];
            prevKust = chernikaOnKusts[i - 1];
        }
        else
        {
            nextKust = chernikaOnKusts[i + 1];
            prevKust = chernikaOnKusts[i - 1];
        }

        if (maxSum < currentKust + nextKust + prevKust)
            {
                maxSum = currentKust + nextKust + prevKust;
            }

    }
Console.WriteLine($"Максимальное количество ягод, собранное модулем за один заход: {maxSum}");