// ArrayList.cs
using System;
using System.Collections;

public class ArrayListEx
{
    private ArrayList list = new ArrayList();

    public ArrayListEx()
    {
        for (int i = 0; i < 5; i++)
        {
            var rand = new Random();
            list.Add(rand.Next(0, 1000));
        }

        list.Add("stroka");
    }

    public void SearchItem()
    {
        Console.Write("Введите элемент который хотите найти: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (list.Contains(number))
            {
                int x = list.IndexOf(number) + 1;
                Console.WriteLine($"Элемент номер {x}, ваш!");
            }
            else Console.WriteLine("Элемент не найден :(");
        }
        else
        {
            if (list.Contains(input))
            {
                int x = list.IndexOf(input) + 1;
                Console.WriteLine($"Элемент номер {x}, ваш!");
            }
            else Console.WriteLine("Элемент не найден :(");
        }
    }

    public void DelItem()
    {
        Console.Write("Введите элемент для удаления: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (list.Contains(number))
            {
                list.Remove(number);
                Console.WriteLine("Элемент удалён!");
            }
            else Console.WriteLine("Элемент не удалён(");
        }
        else
        {
            if (list.Contains(input))
            {
                list.Remove(input);
                Console.WriteLine("Элемент удалён!");
            }
            else Console.WriteLine("Элемент не удалён(");
        }
    }

    public void PrintCount()
    {
        Console.WriteLine("Количество элементов в списке: " + list.Count);
    }

    public void PrintAll()
    {
        Console.WriteLine("\nТекущий список:");
        foreach (var item in list)
            Console.WriteLine(item);
    }

}