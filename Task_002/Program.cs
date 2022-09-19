int a, b, c;

    Console.WriteLine("Введите три числа: ");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());

    int maximal = Math.Max(Math.Max(a, b), c);

    Console.WriteLine("Наибольшее число {0}", maximal);

    Console.ReadLine();
