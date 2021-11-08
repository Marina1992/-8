using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Выберите любую папку на своем компьютере, имеющую вложенные директории. 
             * Выведите на консоль ее содержимое и содержимое всех подкаталогов.  */
           
            string path = @"C:\Program Files";

            string [] folders = Directory.GetDirectories(path);
            Console.WriteLine("Папки :");
            foreach (string d in folders)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("Файлы :");
            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }

             Console.ReadKey();

        }
    }
}
