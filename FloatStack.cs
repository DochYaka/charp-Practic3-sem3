// FloatStack.cs
using System;
using System.Collections.Generic;

public class FloatStack
{
    
    private Stack<float> floatstack = new Stack<float>();

    public FloatStack(FloatList floats)
    {
        var allfloats = floats.GetListOfFloats();

        foreach (var item in allfloats)
        {
            floatstack.Push(item);
        }        
    }

    public void SearchItem()
    {
        Console.Write("Введите элемент который хотите найти: ");
        var input = Console.ReadLine();

        if (float.TryParse(input, out float targetNumber))
        {
            Stack<float> tempStack = new Stack<float>(floatstack); // Копия стека
            int position = 1;
            bool found = false;

            // Ищем сверху вниз
            while (tempStack.Count > 0)
            {
                float current = tempStack.Pop();
                if (current == targetNumber)
                {
                    Console.WriteLine($"Элемент {targetNumber} найден на позиции {position} (сверху)");
                    found = true;
                    break;
                }
                position++;
            }

            if (!found)
            {
                Console.WriteLine($"Элемент {targetNumber} не найден в стеке");
            }
        }
    }

    public void PrintAll()
    {
        Console.WriteLine("\nТекущий стак флотсов:");
        foreach (var item in floatstack)
            Console.WriteLine(item);
    }

}