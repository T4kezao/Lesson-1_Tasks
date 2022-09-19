int a;

    Console.WriteLine("Введите число: ");

    a = Convert.ToInt32(Console.ReadLine());

    if ((a % 2) == 0)

        Console.WriteLine("Введеное число - четное!");
    else

        Console.WriteLine("Введеное число - нечетное!");

    Console.ReadLine();   