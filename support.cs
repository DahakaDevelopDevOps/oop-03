using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using static oop.Queue;
using oop;

namespace oop
{
    class Program
    {

        public static string AboutOrg(Production production)
        {
            return $"Объект: ID: {production.Id}, название организации: {production.Organization}";
        }

        public static string AboutDev(Developer developer)
        {
            return $"Объект: ID: {developer.Id}, фио: {developer.FIO}, отдел: {developer.department}";

        }
        static void Main(string[] args)
        {
            QueueTest();
            var Q1 = new Queue(new List<int>() { 8, -9, 6, -5, 9 });
            var Q2 = new Queue(new List<int>() { 0, 1, 0, 3, 8 });
            Console.WriteLine("Очередь 1: ");
            foreach (var i in Q1.List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nОчередь 2: ");
            foreach (var i in Q2.List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            string str = "Сегодня 1 невероятно хорошая погода, жаль что солнце слабо греет";
            Console.WriteLine($"Строка: {str}");
            Production Goodobj = new Production();
            Console.WriteLine(value: AboutOrg(Goodobj));
            Developer developer = new Developer();
            Console.WriteLine(value: AboutDev(developer));
            Console.WriteLine($"Сумма максимального и минимального элемента  = {StatisticOperation.Sum(Q1)}");
            Console.WriteLine($"Разница между максимальным и минимальным элементом = {StatisticOperation.Difference(Q1)}");
            Console.WriteLine($"Количество элементов: {StatisticOperation.Length(Q1)}");
            bool b = str.FindTheNumber();
            Console.Write($"\nЕсть ли в строке цифра:\n{b}");
            Console.Write("\nОчередь: ");
            foreach (var i in Q1.List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nИзменненная очередь: ");
            Q1.FindNegative();
        }
    }
}
