// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2clear

void InputArr(int[] array) 
{     
    for (int i = 0; i < array.Length; i++)         
    array[i] = new Random().Next(100, 1000);
     }   
    int ReleaseArr(int[] array) 
    {     
        int countEven = 0;     
    for (int i = 0; i < array.Length; i++)    
     {        
         if (array[i] % 2 == 0)            
          countEven++;     
          }
               return countEven; 
               }  

Console.Clear(); 
Console.Write("Введите количество элементов массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; InputArr(array); 
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
Console.WriteLine($"Количество четных чмсел в массиве: {ReleaseArr(array)}");
 
 