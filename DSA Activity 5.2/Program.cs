using System;
using System.Collections;

namespace DSAActivity51
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            int choice;
            do
            {          
                Console.WriteLine("Choose what you want to do?");
                Console.WriteLine("1 - PUSH");
                Console.WriteLine("2 - POP");
                Console.WriteLine("3 - SEARCH");
                Console.WriteLine("4 - PEEK");
                Console.WriteLine("5 - DISPLAY");
                Console.WriteLine("6 - COUNT");
                Console.WriteLine("7 - EXIT");
                Console.Write("Enter code: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter new data to push: ");
                        int data = Convert.ToInt32(Console.ReadLine());

                        stack.Push(data);
                        Console.WriteLine("New data has been added!");
                        break;
                    case 2:
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty.");
                        }
                        else
                        {
                            Console.Write("\nEnter how many data you want to pop: ");
                            int popCount = Convert.ToInt32(Console.ReadLine());

                            if (popCount > stack.Count)
                            {
                                Console.WriteLine("Operation not accepted.");
                            }
                            else
                            {
                                for (int i = 0; i < popCount; i++)
                                {
                                    stack.Pop();
                                }

                                Console.WriteLine("Data removed successfully.");
                            }
                        }
                        break;

                    case 3:
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty.");
                        }
                        else
                        {
                            Console.Write("\nEnter data to search: ");
                            int search = Convert.ToInt32(Console.ReadLine());

                            if (stack.Contains(search))
                            {
                                Console.WriteLine("Data found.");
                            }
                            else
                            {
                                Console.WriteLine("Data not found.");
                            }
                        }
                        break;

                    case 4:
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty.");
                        }
                        else
                        {
                            Console.WriteLine("\nTop Data: " + stack.Peek());
                        }
                        break;

                    case 5:
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty.");
                        }
                        else
                        {
                            Console.WriteLine("\nStack Elements:");
                            foreach (object item in stack)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("\nTotal Number of Items: " + stack.Count);
                        break;

                    case 7:
                        Console.WriteLine("\nProgram Ended.");
                        break;

                    default:
                        Console.WriteLine("\nInvalid Choice!");
                        break;
                }

            } while (choice != 7);

            Console.ReadKey();
        }
    }
}
