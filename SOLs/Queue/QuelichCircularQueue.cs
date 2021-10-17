using System;

namespace SOLs.Queue
{

    public class QCircularQueue
    {
        private int Size { get; set; }
        private int[] Queue;
        // Index to indicate the starting point
        public int Head { get; set; }
        public int Tail { get; set; }

        public QCircularQueue(int k)
        {
            Queue = new int[k];
            Size = 0;
            Head = 0;
            Tail = -1;
        }

        public bool EnQueue(int value)
        {
            // If the queue is full, add none
            if (IsFull())
            {
                return false;
            }
            // Circular increment
            Tail = (Tail + 1) % Queue.Length;
            Queue[Tail] = value;
            Size++;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            // Circular decrement
            Head = (Head + 1) % Queue.Length;
            Size--;
            return true;
        }

        public int Front()
        {
            return IsEmpty() ? -1 : Queue[Head];
        }

        public int Rear()
        {
            return IsEmpty() ? -1 : Queue[Tail];
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public bool IsFull()
        {
            return Size == Queue.Length;
        }
        public void Print()
        {
            foreach (var num in Queue)
            {
                Console.Write(num + " ");
            }
            System.Console.WriteLine();
        }
    }

}