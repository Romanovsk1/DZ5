using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;

namespace DZ5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите из набора этих чисел через пробел что бы сохранить  0 .... 255");

            string Number = Console.ReadLine();

            string[] Numbers = Number.Split();

            byte[] NumberByte = new byte[256];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Convert.ToByte(NumberByte[i]);

                NumberByte[i] = Convert.ToByte(Numbers[i]);

            };
            File.WriteAllBytes("bytes.bin", NumberByte);

            byte[] fil = File.ReadAllBytes("bytes.bin");

            Console.WriteLine(fil);











        }
    }
}
