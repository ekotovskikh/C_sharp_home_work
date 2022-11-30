Console.Clear();

Console.Write("Введите день недели цифрой от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел

if (n==7 || n==6)
    Console.Write("Это выходной день, отдыхайте!");
else
Console.Write("Рабочий день, работайте!");
