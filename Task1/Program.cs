using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\YandexDisk\Курс ИТМО\СSharp";
            string[] dires = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            Console.WriteLine("Папки и подпапки:");
            foreach (string dir in dires)
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine();
            Console.WriteLine("Файлы во всех папках и подпапках:");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
