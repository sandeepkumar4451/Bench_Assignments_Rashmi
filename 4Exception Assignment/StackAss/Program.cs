using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAss
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackException myStack = new StackException();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            // Console.WriteLine("Item popped from Stack : {1}", myStack.POP());
            myStack.POP();
            myStack.POP();
            myStack.POP();
            myStack.POP();
            myStack.PrintStack();
            Console.ReadKey();
        }
    }
}
