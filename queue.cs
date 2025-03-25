using System;

namespace dsa_with_csharp
{
    public class Queue1<T>
    {
        private T[] queue;
        private int front;
        private int rear;
        private int size;

        public Queue1(int size = 10)
        {
            this.size = size;
            queue = new T[size];
            front = -1;
            rear = -1;
        }

        public void Enqueue1(T element)
        {
            if (rear == size - 1)  
            {
                throw new Exception("Queue is Full");
            }

            if (front == -1) 
            {
                front = 0;
            }

            queue[++rear] = element;
            Console.WriteLine($"Enqueued: {element}");
        }

        public T Dequeue1()
        {
            if (front == -1 || front > rear)  
            {
                throw new Exception("Queue is empty");
            }

            T dequeuedElement = queue[front++];
            Console.WriteLine($"Dequeued: {dequeuedElement}");

            // Reset queue when empty
            if (front > rear)
            {
                front = rear = -1;
            }

            return dequeuedElement;
        }

        public void Display()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.Write("Queue contents: ");
            for (int i = front; i <= rear; i++)
            {
                Console.Write(queue[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
