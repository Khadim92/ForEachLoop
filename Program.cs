using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
