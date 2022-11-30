Console.Clear(); 

Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine()); //ввод числа

if (n > 99)
{ int n1 = n/100;
     int n2 = n % 10;
        Console.Write($"3-е число: {n2}"); 
        }
else
{
Console.Write("3-е число отсутствует"); 
}


 
        



