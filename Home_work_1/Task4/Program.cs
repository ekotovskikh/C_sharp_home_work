Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 3-о число: ");
int l = Convert.ToInt32(Console.ReadLine()); // ввод чисел


if ( m > n)
    if ( m > l)
    Console.Write($"Максимальное число {m}");
    else 

        Console.Write($"Максимальное число {l}"); 

    else if (n>l)
Console.Write($"Максимальное число {n}");

else 
    Console.Write($"Максимальное число {l}"); 
