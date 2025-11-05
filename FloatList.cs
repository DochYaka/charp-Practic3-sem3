// FloatList.cs
using System;
using System.Collections.Generic;

public class FloatList
{
    private List<float> floats = new List<float>();

    public FloatList()
    {
        float min = 0.0f;
        float max = 10.0f;

        for (int i = 0; i < 10; i++)
        {
            float val = (float)(min + new Random().NextDouble() * (max - min));
            floats.Add(val);
        }
    }

    public List<float> GetListOfFloats()
    {
        return floats;
    }

    public void DeleteItems()
    {
        int input = InputFunc.ReadInt("С какого элемента начать удаление: ", 1, floats.Count) - 1;
        int count = InputFunc.ReadInt("Сколько элементов хотите удалить: ", 0, floats.Count);

        if (input >= 0 && input + count <= floats.Count)
        {
            floats.RemoveRange(input, count);
            Console.WriteLine($"Элементы удалены с {input + 1} по {input + count}");
        }
        else
        {
            Console.WriteLine($"Нельзя удалить {count} элементов начав с {input + 1}, вы вылезаете за границы списка {floats.Count}");
        }
    }

    public void AddItems()
    {
        // 1. Add — добавляем один элемент
        floats.Add(1.1f);
        floats.Add(2.2f);

        // 2. AddRange — добавляем несколько элементов сразу
        floats.AddRange(new float[] { 3.3f, 4.4f, 5.5f });

        // 3. Insert — вставляем элемент в конкретное место (по индексу)
        floats.Insert(0, 0.0f); // в начало списка
        floats.Insert(3, 1.5f); // вставляем в середину

        // 4. InsertRange — вставляем несколько элементов в середину
        floats.InsertRange(2, new float[] { 0.5f, 0.75f });
    }

    public void PrintAll()
    {
        Console.WriteLine("\nТекущий список флотсов:");
        foreach (var item in floats)
            Console.WriteLine(item);
    }

}
