/*Поиск индекса первого совпадения. 
Дан массив строк и строка образец. Нужно выдать индекс первого совпадения строки с образцом. Если нет совпадений вернуть -1.*/



/*Развернуть массив строк в обратном порядке*/

using System.Diagnostics.Tracing;

class Program
{
    static string[] ReverseArray(string[] words),string outWords)
        {
            string[] words = new string[words.Length];
            for (int i =words.Length-1; i>=0;i--)
            {
                outWords+= words[i];
            }
        return outWords;
        }
}

static void Main(string[] args)
    {
        string[] input = { "тыква", "яблоко", "баклажан", "ранетка", "томаты" };
        string[] output = ReverseArray;
        Console.WriteLine("Результат в обратном порядке:"{result.outWords}");
    }
