Console.Clear ();

string[] arr1 = new string[4] {"lol", "4532", "75", "world"};
string[] arr2 = new string[arr1.Length];
Console.WriteLine ("Начальный массив:" + (arr1[0], arr1[1], arr1[2], arr1[3]));
 

void Array (string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
    }

Array(arr1, arr2);
Console.Write("Обработанный массив: ");
PrintArray(arr2);