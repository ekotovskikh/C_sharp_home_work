Console.Clear(); 

Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine()); // ввод числа

    if ( n%2==0 )
    Console.Write($"Число: {n} является четным");
        else     
    Console.Write($"Число: {n} не является четным");