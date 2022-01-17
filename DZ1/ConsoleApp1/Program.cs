using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            
            
                Console.WriteLine($"Enter text:____");

                string Text = Console.ReadLine();

                File.WriteAllText("Text.txt", Text);//Создаёт и записывает

                if (File.Exists("Text.txt"))
                {
                    System.Console.WriteLine("Сохранено");//проверяет

                }

                string _readText = File.ReadAllText("Text.txt");//Читает файл
                Console.WriteLine(_readText);
            

            Console.ReadLine();
        }
    }
}
