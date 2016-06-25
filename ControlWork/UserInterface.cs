using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControlWork
{
    class UserInterface
    {
        internal void DisplayFactorial()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((new string('=', 79)));
            Console.WriteLine("\t\t\tКонтрольные задания по C#");
            Console.WriteLine((new string('=', 79)));
            Console.WriteLine("\n");
            Console.WriteLine("Задание 1.\nВведите целое неотрицательное число от 1 до 100 для вычисления факториала:");
            Console.ForegroundColor = ConsoleColor.White;
            int x = int.Parse(Console.ReadLine());

                if (x > 100)
                {
                    Console.WriteLine("Введено слишком большое число для отображения результата!");
                }
                else
                {
                    var fact = new Factorial();             
                    Console.WriteLine("Рекурсивное вычисление факториала числа {0}\nРезультат - {1}\n", x, fact.recursiveFact(x));
                    Console.WriteLine("Циклическое вычисление факториала числа {0}\nРезультат - {1}\n", x, fact.cycleFact(x));
                }
            Console.WriteLine("Для перехода к следующему заданию нажмите любую клавишу...");
            Console.ReadKey();
         }

        internal void DisplaySort()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((new string('=', 79)));
            Console.WriteLine("\t\t\tКонтрольные задания по C#");
            Console.WriteLine((new string('=', 79)));
            Console.WriteLine("\n");
            Console.WriteLine("Задание 2.\nСортировка массива из 100 чисел:");
            var so = new SortingOperations();
            int[] mas = new int[100];
            Random rd = new Random();
            for (int i = 0; i < mas.Length; ++i)
                mas[i] = rd.Next(1, 101);
            Console.WriteLine("Массив перед сортировкой:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int x in mas)
            {
                Console.Write(x + " ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");

            Console.WriteLine("Сортировка массива слиянием:");
            Console.ForegroundColor = ConsoleColor.White;
            int [] mergeMas = so.mergeSort(mas);
            foreach (int x in mergeMas)
            {
                Console.Write(x + " ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");

            Console.WriteLine("Сортировка массива выбором:");
            Console.ForegroundColor = ConsoleColor.White;
            int[] selectionMas = so.SelectionSort(mas);
            foreach (int x in selectionMas)
            {
                Console.Write(x + " ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            
            Console.WriteLine("Сортировка массива вставкой:");
            Console.ForegroundColor = ConsoleColor.White;
            int[] insertionMas = so.InsertionSort(mas);
            foreach (int x in insertionMas)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Для перехода к следующему заданию нажмите любую клавишу...");
            Console.ReadKey();
        }
        
        internal void DisplayEncryptedWord()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((new string('=', 79)));
            Console.WriteLine("\t\t\tКонтрольные задания по C#");
            Console.WriteLine((new string('=', 79)));
            Console.WriteLine("\n");
            Console.WriteLine("Задание 3.\nВведите слово на русском языке для шифрования:");
            Console.ForegroundColor = ConsoleColor.White;
            var wr = new WordReplacement();
            string userWord = Console.ReadLine().ToLower();
            if (userWord != null)
            {
                Regex regex = new Regex("[а-яА-Я]");
                if (!regex.IsMatch(userWord))
                {
                    Console.WriteLine("Слово может содержать только прописные и заглавные буквы русского алфавита!");
                }
                else
                {
                    Console.WriteLine("Исходное слово - {0}, зашифрованное - {1}", userWord, wr.Replacement(userWord));
                }
               
            }
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
