﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите числа через запятую:");
            string str = Console.ReadLine();

            string[] array = str.Split(",");


            int countOfPositive = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (int.TryParse(array[i], out int number) && number > 0)
                    countOfPositive++;
            }

            Console.WriteLine($"количество положительных чисел, введеных с клавиатуры: {countOfPositive}");
            
