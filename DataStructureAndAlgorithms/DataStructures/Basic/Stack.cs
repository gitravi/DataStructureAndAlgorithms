using System;

namespace DataStructureAndAlgorithms.DataStructures.Basic
{
    //interface not created to focus on Stack.
    //C#- Generics has been used.
    public class MyStack<T>
    {
        private T[] Storage { get; set; }
        public int Capacity { get; set; }
        public int Top { get; set; }

        public MyStack(int capacity = 10)
        {
            Capacity = capacity;
            Storage = new T[Capacity];
            Top = -1;
        }

        public void Push(T item)
        {
            //Check overflow
            if (Top == Capacity - 1)
            {
                throw new StackOverflowException($"Stack Overflow - Error:Stack is Full(Capacity:{Capacity}).");
            }
            else
            {
                Top++;
                Storage[Top] = item;
            }
        }

        public T Pop()
        {
            //Check underflow
            if (Top == -1)
            {
                throw new InvalidOperationException("Stack is Empty.");
            }
            else
            {
                var item = Storage[Top--];
                return item;
            }
        }

        public override string ToString()
        {
            return $"Stack has {Top + 1} items and a capacity of {Capacity}. Top is at {Top}";
        }
    }
}
