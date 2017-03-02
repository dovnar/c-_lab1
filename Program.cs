using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            /*
            double[] a = new double[5];
            double[,] b = new double[3, 4];
            for(int i = 0; i < 5; i++)
            {
                a[i] = Double.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j< 4; j++)
                {
                    b[i, j] = rand.NextDouble();
                }
            }
            int size = 5 + 3 * 4;
            double[] result = new double[size];
            int it = 0;
            double sum_A = 0;
            for(int i = 0; i < 5; i++)
            {
                if(i%2 == 0)
                {
                    sum_A +=  (a[i]);
                }
                Console.Write("{0 : 0.0000}  ", a[i]);
                result[it] = a[i];
                it++;
            }
            Console.Write("\n");
            float sum_B = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(j%2 != 0)
                {
                    sum_B += Convert.ToSingle(b[i, j]);
                }
                    Console.Write("{0 : 0.0000}  ", b[i, j]);
                    result[it] = b[i, j];
                    it++;
                }
                Console.Write("\n");
            }
            double min  = Double.MaxValue;
            double max = Double.MinValue;
            double sum = 0;
            double mult = 1;
            for(int i = 0; i < size; i++)
            {
                sum += result[i];
                mult *= result[i];
                if(max <= result[i])
                {
                    max = result[i];
                }
                if (min >= result[i])
                {
                    min = result[i];
                }
            }
            Console.WriteLine("общий максимальный элемент  = {0 : 0.0000} \nобщий минимальный элемент = {1 : 0.0000} \nобщая сумма всех элементов = {2 : 0.0000}", max, min, sum);
            Console.WriteLine("общее произведение всех элементов = {0 : 0.00000000000000000000}\nсумма четных элементов массива А = {1 : 0.0000}\nсумма нечетных столбцов массива В = {2 : 0.0000}\n", mult, sum_A, sum_B);
            */
            /*
            int N, M;
            Console.Write("введите занчение N = ");
            N = Int16.Parse(Console.ReadLine());
            Console.Write("введите занчение M = ");
            M = Int16.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            int[] arr2 = new int[M];
            int[] arr3 = new int[N + M];
            for(int i = 0; i < N; i++)
            {
                arr1[i] = rand.Next(0, 10);
            }
            for (int i = 0; i < M; i++)
            {
                arr2[i] = rand.Next(0, 10);
            }
            Array.Sort(arr1);
            Array.Sort(arr2);
            int iter_in_arr3 = 0;
            foreach(int iter in arr1)
            {
                int i = 1000;
                i = Array.IndexOf(arr2, iter);
                if(i != -1)
                {
                    if (arr3[iter_in_arr3 == 0 ? 0 : iter_in_arr3 -1] != arr2[i])
                    {
                        arr3[iter_in_arr3] = arr2[i];
                        iter_in_arr3++;
                    }
                }
            }
            foreach (int iter in arr1)
            {
                Console.Write(iter + " ");
            }
            Console.Write("\n");
            foreach (int iter in arr2)
            {
                Console.Write(iter + " ");
            }
            Console.Write("\n");
            foreach(int iter in arr3)
            {
                Console.Write(iter + " ");
            }
            Console.Write("\n");
            */
            int[,] arr = new int[5,5];
            int[] min = new int[3];
            min[0] = Int32.MaxValue; 
            int[] max = new int[3];
            max[0] = Int32.MinValue;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i,j] = rand.Next(-100, 100);
                    if(min[0] > arr[i,j])
                    {
                        min[0] = arr[i, j];
                        min[1] = i;
                        min[2] = j;
                    }
                    if (max[0] < arr[i, j])
                    {
                        max[0] = arr[i, j];
                        max[1] = i;
                        max[2] = j;
                    }
                }
            }
            int summ = 0;
            if(min[1] < max[1])
            {
                for(int i = min[1]+1; i < max[1]; i++)
                {
                    for(int j = min[2]; j < (i == max[1]? max[2]: 5); j++)
                    {
                        summ += arr[i, j];
                    }
                }
            }
            else if (min[1] > max[1])
            {
                for (int i = max[1] + 1; i < min[1]; i++)
                {
                    for (int j = max[2]; j < (i == min[1] ? min[2] : 5); j++)
                    {
                        summ += arr[i, j];
                    }
                }
            }
            else if (min[1] == max[1])
            {
                if (min[2] < max[2])
                {
                    for (int j = min[2]; j <  max[2]; j++)
                    {
                        summ += arr[min[1], j];
                    }
                }
                else if (min[2] > max[2])
                {
                    for (int j = max[2]; j < min[2]; j++)
                    {
                        summ += arr[max[1], j];
                    }
                }
            }
            Console.WriteLine("сумма чисел между минимальным и максимальным значениями = {0}", summ);
        }
    }
}
