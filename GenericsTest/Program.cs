using System;

namespace GenericsTest
{
    /// <summary>
    /// This data storage class works on 'LIFO' (Last In - First Out) principle. Based on array.
    /// </summary>
    public class Stack<T>
    {
        T[] arr = new T[0];

        /// <summary>
        /// Prints all elements in stack.
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i} -> {arr[i]}");
            }
        }

        /// <summary>
        /// Push a new element to the tail of array.
        /// </summary>
        public void Push(T val)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = val;
        }

        /// <summary>
        /// Delete element from tail.
        /// </summary>
        public void Delete()
        {
            if (arr.Length > 0)
                Array.Resize(ref arr, arr.Length - 1);
            else
                Console.WriteLine("Array size is 0!");
        }

        /// <summary>
        /// Returns an array size.
        /// </summary>
        public int GetSize()
        {
            return arr.Length;
        }
    }

    /// <summary>
    /// Basic button class. Consists purely of strings.
    /// </summary>
    public class Button
    {
        string text;
        string action;
        public Button()
        {
            text = "Generic Button";
            action = "Generic Action";
        }
        public Button(string text)
        {
            this.text = text;
            action = "Generic Action";
        }
        public Button(string text, string action)
        {
            this.text = text;
            this.action = action;
        }

        /// <summary>
        /// Prints button label.
        /// </summary>
        public void Info()
        {
            Console.WriteLine(text);
        }
        /// <summary>
        /// Prints button action on press.
        /// </summary>
        public void Press()
        {
            Console.WriteLine(action);
        }
    }

    class Program
    { 
        static void Main()
        {
            Stack<string> stack = new();
            stack.Push("AA");
            stack.Push("BB");
            stack.Push("CC");
            stack.Delete();
            stack.Print();

            Button button = new();
            button.Info();
            button.Press();
        }
    }
}