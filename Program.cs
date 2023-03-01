int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода: ");
    Console.WriteLine("1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
           /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            [345, 897, 568, 234] -> 2 */

            Console.WriteLine("Введите длину массива:  ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            
            RandonNumbers(numbers);
            Console.WriteLine("В этом массиве: ");
            PrintArray(numbers);

            void RandonNumbers(int[] numbers)
            {
                for(int i = 0; i < size; i++)
                {
                    numbers[i] = new Random().Next(100,1000);
                }
            }


            int count = 0;

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % 2 == 0)
                count++;
            }
            Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


            void PrintArray(int[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("]");
                Console.WriteLine();
            }

            break;


        case 2:
           /* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            [3, 7, 23, 12] -> 19
            [-4, -6, 89, 6] -> 0  */
            
            int size_1 = ReadInt("Введите размерность массива: ");
            int min = ReadInt("Введите минимальное число массива: ");
            int max = ReadInt("Введите максимальное число массива: ");
            int [] numbers_1 = new int[size_1];

            FillArrayRandomNumbers(numbers_1);
            PrintArrayOne(numbers_1);
            int result = 0;

            for (int i = 0; i < numbers_1.Length; i++)
            {   
                if (i % 2 != 0)
                {
                    result += numbers_1[i];
                }
            }
            Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

            void FillArrayRandomNumbers(int [] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(min, max);
                }
            }

            void PrintArrayOne(int[] array) 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            int ReadInt(string message)  
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }

            break;
        case 3:
            /* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            [3 7 22 2 78] -> 76*/
            

            
            break;
    }
}