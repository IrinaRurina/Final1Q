using System;

namespace Find123Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write ("Введите символ или слово: ");
                array[i] = Console.ReadLine();
            }
            Console.WriteLine();
            
            Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

            Console.Write("Итоговый массив: [");
            int count = 0;

            for (int i = 0; i < n; i++)
            {                
                int length = array[i].Length;
                if (length <=3 && count ==0)
                {
                    Console.Write(array[i]);
                    count++;
                } 
                else if (length <=3 && count > 0)
                {
                    Console.Write(", " + array[i]);
                    count++;
                }   
            }
            Console.WriteLine("]");


        }
    }
}
