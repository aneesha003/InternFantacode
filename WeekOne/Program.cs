
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    
    class StackClass<T>
    {

        int size;
        T[] stackArray;
        int top;
        public StackClass(int Max)
        {
            size = Max;
            stackArray = new T[size];
            top = -1;
        }
        public int push(T Element)
        {
            if (top == size - 1)
            {
                return -1;
            }
            else
            {
                top = top + 1;
                stackArray[top] = Element;

            }
            return 0;
        }
        public T pop()
        {
            T Element;
            T temp = default(T);
           
            if (top > 0)
            {
                Element = stackArray[top];
                top = top - 1;
                return Element;
            }
            return temp;
        }
        public T peep(int position)
        {
            T temp = default(T);
            if (position < size && position >= 0)
            {
                return stackArray[position];
            }
            return temp;
        }
        public T[] GetAllStackElements()
        {
            T[] Elements = new T[top+1];
            Array.Copy(stackArray, 0, Elements, 0, top+1);
            return Elements;
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of the stack: ");
            size = int.Parse(Console.ReadLine());

            StackClass<object> stck = new StackClass<object>(size);

            while (true)
            {
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Search (given position)");
                Console.WriteLine("4.Print stack elements: ");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the element to push : ");
                            object temp = Console.ReadLine();
                            int result = stck.push(temp);
                            if (result!= -1)
                            {
                                Console.WriteLine("Element has been pushed to stack!");
                            }
                            else
                            {
                                Console.WriteLine("Stack overflow!");
                            }
                            break;
                        }
                    case 2:
                        {
                            object result = stck.pop();
                            if (result != null)
                            {
                                Console.WriteLine("Deletd Element : " + result);

                            }
                            else
                            {
                                Console.WriteLine("Stack underflow!");
                            }
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the position of the element to search:");
                            int position = int.Parse(Console.ReadLine());
                            object result = stck.peep(position);

                            if (result != null)
                            {
                                Console.WriteLine("Element at Position " + position + "is " + result);
                            }
                            else
                            {
                                Console.WriteLine("Entered element id Out of Stack Range");
                            }
                            break;
                        }
                    case 4:
                        {
                            object[] Elements = stck.GetAllStackElements();
                            Console.WriteLine("*******Stack Content**********");

                            foreach (object obj in Elements)
                            {
                              
                                Console.WriteLine(obj);
                            }
                            break;
                        }
                    case 5:
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have Entered wrong choice ");
                            break;
                        }


                }

            }

        }
    }
}

