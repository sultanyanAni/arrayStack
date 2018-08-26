using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniArrayStack
{
    class Stack<T>
    {
        T[] theStack;
        int Count => theStack.Length;
        public Stack()
        {
            theStack = new T[0];
        }
        public void Print()
        {
            for (int i = 0; i < theStack.Length; i++)
            {
                Console.WriteLine(theStack[i]);
            }
        }
        public bool IsEmpty()
        {
            return theStack.Length == 0;
          
        }
        public void Push(T itemToPush)
        {
            T[] temp = new T[theStack.Length + 1];
            temp[0] = itemToPush;
            for (int i = 1; i < theStack.Length + 1; i++)
            {
                temp[i] = theStack[i - 1];
            }
            theStack = temp;
        }

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("The Stack Is Empty");
            }
            T valueToCheck = theStack[0];
            T[] temp = new T[theStack.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {

            }
            return valueToCheck;

        }

    }
}
