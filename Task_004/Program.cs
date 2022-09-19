int N;

Console.WriteLine("Введите необходимый диапозон: ");
N = Convert.ToInt32(Console.ReadLine());
int i = 1;
    for (i = 1; i <= N; i++)
        if ((i % 2) == 0 )
        Console.WriteLine("В этом диапозоне найдены четные числа числа: " + i);
    Console.ReadLine();