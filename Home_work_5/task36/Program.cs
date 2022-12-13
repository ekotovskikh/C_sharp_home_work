// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void InputArr(int[] array) 
{     
    for (int i = 0; i < array.Length; i++)     
    {         
        int x = new Random().Next(-100, 100);        
         while (array.Contains(x))             
         x = new Random().Next(-100, 100);        
          array[i] = x;     
          } 
        }   
          int ReleaseArr(int[] array) 
          {     
            int sumUnOdd = 0;     
            for (int i = 1; i < array.Length; i+=2)         
            sumUnOdd += array[i];     
            return sumUnOdd; 
            }   
            Console.Clear(); 
            Console.Write("Введите количество элементов массива: "); 
            int n = Convert.ToInt32(Console.ReadLine()); 
            int[] array = new int[n]; 
            InputArr(array); 
            Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
            Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях:{ReleaseArr(array)}");