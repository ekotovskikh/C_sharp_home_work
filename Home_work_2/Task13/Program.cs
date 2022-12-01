Console.Clear(); 

Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine()); //ввод числа

if (n < 100)     
Console.WriteLine("Третьей цифры нет, попробуйте еще раз!"); 
else 
{     
        while (n > 1000)        
         n = n / 10;          
         Console.WriteLine ($"Третья цифра: {(n%10)}"); 
         }
 
        



