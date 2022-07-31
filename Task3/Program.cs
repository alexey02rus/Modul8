using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ASUS ROG\Desktop\numbers.txt";
            FileInfo fileInfo = new FileInfo(path);
            int i = 0;
            int j = 0;
            int length1 = 0;
            int length2 = 0;
            int count = 0;
            string str;
            Console.WriteLine($"Имя файла: {fileInfo.Name}");
            Console.WriteLine($"Полный путь до файла: {fileInfo.DirectoryName}");
            Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
            Console.WriteLine($"Размер: {fileInfo.Length} байт");
            Console.WriteLine();
            Console.WriteLine("Статистика по файлу:");;
            using (StreamReader sr = new StreamReader(path))
            {
                
                while ((str = sr.ReadLine()) != null)
                {
                    i++; // Кол-во строк
                    if (str.Replace(" ","") != "")
                    {
                        j++; // Кол-во не пустых строк
                        length1 += str.Length; // Кол-во симоволов с учетом пробелов
                        length2 += str.Replace(" ", "").Length; // Кол-во симоволов без учета пробелов
                        count += str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length; // Кол-во слов в строке
                    }

                }

            }
            Console.WriteLine("Количество строк в тексте (с учетом пустых): {0}", i);
            Console.WriteLine("Количество строк в тексте (без учета пустых): {0}", j);
            Console.WriteLine("Количество слов в тексте: {0}", count);
            Console.WriteLine("Количество символов в тексте (с учетом пробелов): {0}", length1);
            Console.WriteLine("Количество символов в тексте (без учета пробелов): {0}", length2);
            Console.ReadKey();
        }
    }
}
