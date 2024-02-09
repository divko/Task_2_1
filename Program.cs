using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Иван Иванович";
            byte age = 30;
            string email = "Ivanov@mail.ru";
            double ballsCode = 0;
            double ballsMath = 0;
            double ballsPhis = 0;
            string pattern = "ФИО: {0},\nВозраст: {1}, \nПочта: {2}, \nБаллы по программированию - {3}, \nБаллы по математике - {4}, \nБаллы по Физике - {5}.";
            Console.WriteLine(pattern,fullName,age,email,ballsCode,ballsMath,ballsPhis);
            Console.ReadKey();

        }
    }
}
