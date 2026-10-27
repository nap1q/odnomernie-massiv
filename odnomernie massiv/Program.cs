using System;

class Program
{
    static void Main()
    {
    
        string[] binaryArray = { "101", "1100", "1111", "10010", "11011" };
        int addend = Convert.ToInt32("1010", 2);

        Console.WriteLine($"Прибавляем двоичное число 1010 (десятичное {addend}) к каждому элементу:\n");
        Console.WriteLine($"{"Исходное (двоичн.)",-20} {"Исходное (10-чн.)",-18} {"Результат (10-чн.)",-20} {"Результат (двоичн.)"}");
        Console.WriteLine(new string('-', 75));

        for (int i = 0; i < binaryArray.Length; i++)
        {
            int value = Convert.ToInt32(binaryArray[i], 2);

            int result = value + addend;

            string resultBinary = Convert.ToString(result, 2);

            Console.WriteLine($"{binaryArray[i],-20} {value,-18} {result,-20} {resultBinary}");
        }
    }
}