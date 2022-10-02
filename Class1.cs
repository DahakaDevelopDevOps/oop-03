using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Reflection;

namespace oop
{
    public partial class Queue
    {
        public List<int> List;
        public Queue(List<int> List) => this.List = List;

        //добавление элемента в очередь
        public static Queue operator /(Queue queue1, int item)
        {
            queue1.List.Add(item);
            return queue1;
        }
        //извлечение элемента из очереди
        public static Queue operator +(Queue queue, int item)
        {
            queue.List.Remove(item);
            return queue;
        }

        //проверка, на содержание четных элементов в очереди;
        public static bool operator false(Queue queue1)
        {
            for (int i = 0; i < queue1.List.Count; i++)
            {
                if (queue1.List[i] % 2 == 0)
                {
                    Console.Write($"Есть четный элемент {queue1.List[i]}");
                    return true;
                }
            }
            return false;
    
        }
        // проверка, на содержание нечетных элементов в очереди
        public static bool operator true(Queue queue1)
        {
            foreach (var i in queue1.List)
            {
                if (queue1.List[i] % 2 == 0)
                {
                    Console.Write($"Есть нечетный элемент {queue1.List[i]}");
                    return true;
                }
            }
            return false;
        }
        //явный int() - количество положительных элементов в очереди
        public int Elements { get; set; }

        public static explicit operator int(Queue Queue1)
        {
            int result = 0;
            for(int i = 0; i< Queue1.List.Count; i++)
            {
                if (Queue1.List[i] > 0)
                    Queue1.Elements++;
            }
            Queue1.Elements = result;
            return Queue1.Elements;
        }

        public static void QueueTest()
        {
            var Queue1 = new Queue(new List<int>() { 1, 2, -3, -10 });
            var Queue2 = new Queue(new List<int>() { 1, 3, 5, 7, 9 });

            Console.Write($"Первая очередь: ");
            foreach (var i in Queue1.List)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            Console.Write($"Вторая очередь: ");
            foreach (var i in Queue2.List)
            {
                Console.Write(i + " ");

            }
            Console.Write($"\nИзвлекаем из первой очереди  1: ");
            var deletedQueue = Queue1 + 1;
            foreach (var i in deletedQueue.List)
            {
                Console.Write(i + " ");
            }

            Console.Write($"\nДобавляем ко второй очереди 10: ");
            var addQueue = Queue2 / 10;
            foreach (var i in addQueue.List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // перегрузка false / t
            if (Queue2)
                Console.WriteLine("\nТест пройден");
            int x = (int)Queue1;
            Console.WriteLine(x);

        }

    }
}