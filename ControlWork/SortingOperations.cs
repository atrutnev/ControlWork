using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class SortingOperations
    {
        //Сортировка слиянием
        internal int[] mergeSort(int[] mas)
        {
            if (mas.Length == 1)
                return mas;
            int middle = mas.Length / 2;
            return Merge(mergeSort(mas.Take(middle).ToArray()), mergeSort(mas.Skip(middle).ToArray()));
        }

        private int[] Merge(int[] mas1, int[] mas2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mas1.Length + mas2.Length];
            for (int i = 0; i < mas1.Length + mas2.Length; i++)
            {
                if (b < mas2.Length && a < mas1.Length)
                    if (mas1[a] > mas2[b])
                        merged[i] = mas2[b++];
                    else
                        merged[i] = mas1[a++];
                else
                    if (b < mas2.Length)
                    merged[i] = mas2[b++];
                else
                    merged[i] = mas1[a++];
            }
            return merged;
        }

        //Сортировка выбором
        internal int[] SelectionSort(int[] mas)
        { 
           for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int temp = mas[i];
                    mas[i] = mas[min];
                    mas[min] = temp;
                }
            }
            return mas;
        }

        //Сортировка вставкой
        internal int[] InsertionSort(int[] mas)
        {
            int[] res = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                int j = i;
                while (j > 0 && res[j - 1] > mas[i])
                {
                    res[j] = res[j - 1];
                    j--;
                }
                res[j] = mas[i];
            }
            return res;
        }
    }
}
