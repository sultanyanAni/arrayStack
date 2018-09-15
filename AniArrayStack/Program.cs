using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 11; i++)
            {
                stack.Push(i + 1);
            }

            Console.WriteLine(stack.Pop());


            Console.ReadKey();
            Console.Clear();
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
