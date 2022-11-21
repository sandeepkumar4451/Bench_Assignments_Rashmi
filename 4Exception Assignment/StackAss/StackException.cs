using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAss
{
    public class StackException
    {
        static int MAX = 100;
        int top = -1;
        int[] Stack = new int[MAX];
        int value;
        public StackException()
        {
            top = -1;
        }
        public void Push(int data)
        {
            if (top == MAX - 1)
            {
                throw new Exception("Stack Overflow =");
            }
            else
            {
                Stack[++top] = data;
            }
        }
        public int POP()
        {
            if (top == -1)
            {
                throw new Exception("Stack UnderFlow =");
            }
            else
            {
                value = Stack[top--];
                return value;
            }
        }
        public void PrintStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(Stack[i]);
                }
            }
        }
    }
}
