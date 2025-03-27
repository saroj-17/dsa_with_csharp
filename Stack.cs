using System;

namespace dsa_with_csharp
{
    public class Stack1
    {
        private int top = -1;
        private int[] stack;

        public Stack1(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public void Push(int element)
        {
            if (top == stack.Length - 1)
            {
                throw new Exception("Stack Overflow condition");
            }
            else
            {
                top++;
                stack[top] = element;
                Console.WriteLine($"Element {stack[top]} added to top of stack");
            }

        }

        public void Pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack is empty");

            }
            else
            {
                Console.WriteLine($"Element Popped is {stack[top]}");
                top--;

            }

        }

        public void Display()
        {

            Console.WriteLine("Elements on Stack are:");

            for (int i = 0; i <= top; i++)
            {
                Console.Write($"{stack[i]}\t");
            }
            Console.WriteLine("\n");
        }

    }
}