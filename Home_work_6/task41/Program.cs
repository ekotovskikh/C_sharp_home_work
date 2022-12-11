// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

 Console.Clear();

Console.Write("Введите элементы через пробел, обязательно: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);// это кончно подсмотрела на просторах, был изнасально более ёмкий вариант
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов больше 0: {count}");


//Console.Clear();
 //Console.Write("Ведите  число M1: "); 
 //int n = Convert.ToInt32(Console.ReadLine());  
 //Console.Write("Ведите  число M2: "); 
 //int n1 = Convert.ToInt32(Console.ReadLine()); 
 //Console.Write("Ведите  число M3: "); 
 //int n2 = Convert.ToInt32(Console.ReadLine()); 
 //Console.Write("Ведите  число M4: "); 
 //int n3 = Convert.ToInt32(Console.ReadLine()); 
 //Console.Write("Ведите  число M5: "); 
 //int n4 = Convert.ToInt32(Console.ReadLine()); 

//int count=0;
     
