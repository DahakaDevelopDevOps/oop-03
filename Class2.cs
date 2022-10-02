using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop
{
    public partial class Queue
    {

        public class Production
        {
            public string Organization { get; set; }
            public readonly int Id;

            public Production()
            {
                Id = GetHashCode();
                Organization = "Организация";
            }
        }

        public class Developer
        {
            public string FIO { get; set; }
            public readonly int Id;
            public string department;

            public Developer()
            {
                Id = GetHashCode();
                FIO = "Светлова Света Святославовна";
                department = "Тестирования";
            }
        }
    }
        public static class StatisticOperation
        {
            public static int Sum(Queue set1)
            {
                return set1.List.Max() + set1.List.Min();
            }

            public static int Difference(Queue set1)
            {
                return set1.List.Max() - set1.List.Min();
            }

            public static int Length(Queue set1)
            {
                return set1.List.Count();
            }

            public static bool FindTheNumber(this string str) //расширенный метод string
            {
                string[] words = str.Split(' ');
                string[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (words[i] == nums[j])
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            public static int FindNegative(this Queue Queue1) //расширенный метод Queue
        {
                for (int i = 0; i < Queue1.List.Count; i++)
                {
                    if (Queue1.List[i] < 0)
                    {
                        Queue1.List[i] = 0;
                        Console.Write(Queue1.List[i] + " ");
                    }
                    else
                        Console.Write(Queue1.List[i] + " ");
                }
                return 0;
            }

        }
}
