using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class MyCollection
    {
        public static void InitHasil()
        {
            var alfabet = new List<string> {"A","B","C","D","E" };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I"});
            alfabet.Insert(0, "J");
            alfabet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfabet)
            {
                Console.Write($"{item} ");
            }
            //remove
            alfabet.Remove("X");
            alfabet.RemoveRange(4,6);
            alfabet.RemoveAll(v=>v=="Y");

            //clear
            alfabet.Clear();

            //declare list
            var Number = new List<int> { 1,3,4,5,6,7 };
            Number.Add(23);
/*            Number.Remove(13);
            Number.RemoveAll(v => v >= 7);*/
            //find element
            var a = Number.Find(e => e < 10);
            var b = Number.FindLast(e => e < 11);
            var c = Number.FindAll(e => e < 10);
            //find index element
            var d = Number.FindIndex(e => e <= 11);
            var e = Number.FindLastIndex(e => e <= 11);
            var f =Number.IndexOf(13);
            var g =Number.BinarySearch(11);
        }
        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3 });
            numbers.Push(4);
            numbers.Push(5);

            //remove
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();
        }

        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");
            var pl2 = new Dictionary<int, string>()
            {
                {1,"c#" },
                {2,"java" },
                {3,"sql" }
            };
            pl2.Add(4, "golang");
            //pl2.Add(4, "pyton");
            pl2.TryAdd(4, "python");
            //merubah data
            pl2[4] = "SQL";
            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        public static void InitHashSet()
        {
            HashSet<int> set = new HashSet<int>()
            {
                1, 2, 3, 4, 5, 6, 7
            };
            set.Add(5);
            set.Add(10);
            set.Add(6);
            ///join
            var set2 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var set3 = new HashSet<int>() { 1, 2, 3, 4 };
            var r1 = new HashSet<int>(set2);
            r1.IntersectWith(set3);///inner join 1,2
            r1.UnionWith(set3); //union join 1,2,3,4,5,6,9
            r1.ExceptWith(set3);//5,6,9
            var r2 = new HashSet<int>(set2);
            r2.SymmetricExceptWith(set3);
            var number = r2.ToList();

        }
        public static void InitQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Asep");
            queue.Enqueue("BUdi");
            queue.Enqueue("Jajang");

            string serve = queue.Dequeue();


            foreach (var item in queue)
            {
                Console.WriteLine($"{item}");
            }
            serve = queue.Dequeue();
            Console.WriteLine($"serve {serve}");
        }

        public static List<T> GetStudent<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            return myList;
        }
    }
}
