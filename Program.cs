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
            // Task_2_1
            string fullName = "Иванов Иван Иванович";
            byte age = 30;
            string email = "Ivanov@mail.ru";
            double ballsCode = 10;
            double ballsMath = 20;
            double ballsPhis = 30;
            string pattern = "ФИО: {0},\nВозраст: {1}, \nПочта: {2}, \nБаллы по программированию - {3}, \nБаллы по математике - {4}, \nБаллы по Физике - {5}.";
            Console.WriteLine(pattern,fullName,age,email,ballsCode,ballsMath,ballsPhis);
            Console.ReadKey();
            // или интерполяция строк
            Console.WriteLine($"ФИО: {fullName}" +
                $",\n Возраст:{age}" +
                $",\nПочта: {email}, \nБаллы по программированию - {ballsCode},\nБаллы по математике - {ballsMath},\nБаллы по физике -{ballsPhis}. ");
            Console.ReadKey();
            //Task 2_2
            double nSum;
            double nAverage;
            nSum = (ballsCode + ballsMath + ballsPhis);
            nAverage = nSum / 3;
            Console.WriteLine($"Сумма баллов: {nSum}\nСреднее арифметическое: {nAverage}");
            Console.ReadKey();
        }
    }
}
