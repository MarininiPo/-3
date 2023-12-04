/* 1: Задайте одномерный массив из 10 целых чисел 
от 1 до 100. Найдите количество элементов массива,
значения которых лежат в отрезке [20,90].*/

public const int MIN = 1;
public const int MAX = 100;
public const int FROM = 20;
public const int TO = 90;
public static void Main(string[] args)
{
    System.Console.Write("Введите размерность генерируемого массива: ");

        int arraySize = GetArraySizeFromConsole();
        while (arraySize < 0)
        {
            arraySize = GetArraySizeFromConsole();
        }
        
}