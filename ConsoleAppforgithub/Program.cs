using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppforgithub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine();

            Console.Write("Введіть вік: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ім'я: {name}  Вік: {age}");
        }
    }
}
