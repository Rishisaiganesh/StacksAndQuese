using System;

namespace StacksAndQuese
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlecome to Satacks And queue");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("stacklist Elements");
            stack.Display();
            stack.Pop();
            Console.WriteLine("List After Poping");
            stack.Display();
            stack.Peek();
            Console.WriteLine("list after Peek");
            stack.Display();
            stack.Size();
        }
    }
}
