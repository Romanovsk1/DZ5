using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DZ5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string time = DateTime.Now.ToString("F");
            File.WriteAllText("startup.txt", time);
             
            
            if (File.Exists("startup.txt"))
            {
                System.Console.WriteLine("File Exists!");
            }

            string Text = File.ReadAllText("startup.txt");

            System.Console.WriteLine(Text);

            System.Console.ReadLine();


        }
    }
}
