Console.Clear(); 

Console.Write("Введите 3-х значное число: "); 
int n = Convert.ToInt32(Console.ReadLine()); // ввод числа
while (n < 100 || n > 999) 
{     Console.Write("Вы ошиблись!\nВведите 3-x значное число: ");    
 n = Convert.ToInt32(Console.ReadLine());     
 } 

n = n / 10 % 10;
 Console.WriteLine($"Вторая цифра введённого числа: {n}");

