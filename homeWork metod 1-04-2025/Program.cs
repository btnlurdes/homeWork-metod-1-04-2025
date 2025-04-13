/*Поиск индекса первого совпадения. 
Дан массив строк и строка образец. Нужно выдать индекс первого совпадения строки с образцом. Если нет совпадений вернуть -1.*/



/*Развернуть массив строк в обратном порядке

using System;
class Program
{

    static string[] ReverseArray(string[] words)
    {
        string[] reversedWords = new string[words.Length];//создан новый массив для обратного порядка
        for (int i = 0; i < words.Length; i++)
        {
            reversedWords[i] = words[words.Length - 1 - i];//заполняем новый массив в обратном порядке
        }
        return reversedWords;//выдает новый массив
    }
    static void Main(string[] args)
    {
        string[] input = { "тыква", "яблоко", "баклажан", "ранетка", "томаты" };
        string[] output = ReverseArray(input);//вызывает метод и берет массив

        Console.WriteLine("Результат в обратном порядке:");
        foreach (string word in output)
        {
            Console.WriteLine(word);//вывод элементов массива
        }
    }
}*/


