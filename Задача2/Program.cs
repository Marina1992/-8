using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
             * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.  */

            string path = @"C:\Users\Admin\Desktop\ИТМО\домашки\Задание8\text2.txt";

            StreamWriter a = new StreamWriter(path);
            double[] numbers = new double[10];
            Random random = new Random();
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 10);
                a.WriteLine(numbers[i]);
                sum += numbers[i];
            }

            a.Close();
            StreamReader sr = new StreamReader(path);

            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            Console.WriteLine("Cумма чисел : {0}", sum);

            Console.ReadKey();



        }
    }
}
