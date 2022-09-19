int a, b;
 
    Console.WriteLine("Введите первое число: ");
 
    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");
 
    b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)

            Console.WriteLine("Наибольшее число {0} Наименьшее число {1} " , a, b);
            
        else

            Console.WriteLine("Наибольшее число {0} Наименьшее число {1}", b , a);

        Console.ReadLine();