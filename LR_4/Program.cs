using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject1")]

namespace LR_4
{
    internal class Program
    {
        private static List<int> CreateList()
        {
            var r = new Random();
            var list = new List<int>();
            for (int i = 0; i < r.Next(5, 10); i++)
            {
                list.Add(r.Next(1, 10));
            }
            return list;
        }

        private static string DisplayList(List<int> list) => string.Join(",", list);

        private static List<int> ChangeIndex(List<int> list)
        {
            (list[list.LastIndexOf(list.Max())], list[list.IndexOf(list.Min())])
                = (list[list.IndexOf(list.Min())], list[list.LastIndexOf(list.Max())]);
            return list;
        }

        static void Main()
        {
            var list = CreateList();
            Console.WriteLine($"Massive: {DisplayList(list)}");
            list = ChangeIndex(list);
            Console.WriteLine($"Massive after change: {DisplayList(list)}");
        }
    }
}
