using System;

namespace l4
{
    public class Program
    {
        public static int Nulls(int[] a)
        {
            int k = 0;
            int i;
            int num = 0;
            for (i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 0)
                    k++;
                // кількість нульових елементів
                if (a[i] == 0)
                {
                    ++num;
                }
            }
            Console.WriteLine("Кiлькiсть нульових елементiв = " + num);
            return num;
        }
        public static int Dob(int[] a)
        {
            int maxPosition = 0;
            int maxNum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = a[i];
                if (a[i] < 0)
                    temp = a[i] * (-1);
                if (temp > maxNum)
                {
                    maxNum = temp;
                    maxPosition = i;
                }

            }
            int answer = 1;
            for (int j = maxPosition + 1; j < a.Length; j++)
                answer = answer * a[j];
            Console.WriteLine(" Добуток елементiв, пiсля максимального за модулем " + answer);
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть n");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введiть {0}-й елемент", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            Nulls(a);
            Dob(a);
            Console.ReadLine();

        }
    }
}
