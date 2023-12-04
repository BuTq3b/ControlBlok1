/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/

using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;

Console.Clear();

string[] ResultArr(string[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        string str = a[i];
        if (str.Length <= 3)
        {
            count++;
        }
    }
    string[] newar = new string[count];
    int index = 0;
    for (int i = 0; i < a.Length; i++)
    {
        string str = a[i];
        if (str.Length <= 3)
        {
            newar[index] = a[i];
            index++;
        }
    }
    return newar;
}

string[] ArrayCreation(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите значение строки: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArrey(string[] ar)
{
    System.Console.WriteLine();
        for (int i = 0; i < ar.Length; i++)
    {
        Console.Write(ar[i] + "  ");
    }
        System.Console.WriteLine();
}

string[] arrey = ArrayCreation(3);
PrintArrey(arrey);
Console.WriteLine("===================================================================");
Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам: ");
PrintArrey(ResultArr(arrey));