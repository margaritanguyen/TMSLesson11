using System;

namespace TMSLesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            try
            {
                var genericArrayChar = new GenericArrayClass<char>();
                genericArrayChar.Add('a');
                genericArrayChar.Add('b');
                genericArrayChar.Add('c');
                genericArrayChar.Add('d');
                genericArrayChar.Add('e');
                genericArrayChar.Add('f');
                genericArrayChar.Add('g');
                genericArrayChar.Add('h');
                genericArrayChar.Add('i');
                genericArrayChar.Add('j');
                Console.WriteLine($"Количество элементов в массиве: {genericArrayChar.Count()}");
                Console.WriteLine($"Третий элемент массива: {genericArrayChar.GetElement(3)}");
                Console.WriteLine($"Восьмой элемент массива: {genericArrayChar.GetElement(8)}");
                Console.WriteLine($"Четырнадцатый элемент массива: {genericArrayChar.GetElement(14)}");
                genericArrayChar.Add('k');
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс за пределами массива");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //task2
            Console.WriteLine(GenericAggregateClass<int>.Max(3, 8, 1));
            Console.WriteLine(GenericAggregateClass<decimal>.Max(3.5M, 8.88M, 1.23M));
            Console.WriteLine(GenericAggregateClass<char>.Max('e','u','w'));
            Console.WriteLine(GenericAggregateClass<bool>.Max(true, false, true));
        }
    }
}