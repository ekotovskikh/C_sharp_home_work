Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел

if ( m>n )
    Console.Write($"Максимальное число {m}");
else
    Console.Write($"Максимальное число {n}"); 
