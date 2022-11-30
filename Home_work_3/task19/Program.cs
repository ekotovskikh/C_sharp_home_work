Console.Clear(); 

Console.Write("Введите 5-и значное число: "); 

int n = Convert.ToInt32(Console.ReadLine()); // ввод числа 

if (n/10000 == n % 10 && ((n/1000) % 10) == ((n / 10) % 10)) 
{     Console.WriteLine("Это число вяляется полиндромом"); 
} else 
{     
   Console.WriteLine("Это число не является полиндромом"); 
   }







//if (n < 10000)     
//Console.WriteLine("Вы ошиблись, введите 5-и значное число!"); 

//else 
//{    
   
     //{         
     //Console.WriteLine("Да, число является полиндромом"); 
    //} 
    // else
    //{
       // Console.WriteLine("Нет, число не является полиндромом");
    // }
   // } 