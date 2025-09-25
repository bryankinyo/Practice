using System;
using Library.Classes;
class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        Queue queue = new Queue();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- MAIN MENU ---");
            Console.WriteLine("1. Stack Demo");
            Console.WriteLine("2. Queue Demo");
            Console.WriteLine("3. Exit");
            Console.Write("Select option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                StackMenu(stack);
            else if (choice == "2")
                QueueMenu(queue);
            else if (choice == "3")
                break;
        }
    }

    static void StackMenu(Stack stack)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- STACK MENU ---");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Traverse");
            Console.WriteLine("5. Back");
            Console.Write("Select option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Enter number to push: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        try { stack.Push(num); Console.WriteLine("Pushed!"); }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }

                    Console.WriteLine("\nPress [A] to add another. [Any Key] to go back.");
                    var again = Console.ReadKey();
                    if (again.KeyChar != 'A' && again.KeyChar != 'a')
                        break;
                }
            }
            else if (choice == "2")
            {
                Console.Clear();
                try
                {
                    int val = stack.Pop();
                    Console.WriteLine($"Popped: {val}");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                Console.Clear();
                try
                {
                    int val = stack.Peek();
                    Console.WriteLine($"Peek: {val}");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                Console.ReadKey();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Stack contents (Top to Bottom):");
                stack.Traverse();
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }

    static void QueueMenu(Queue queue)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== QUEUE MENU ===");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Traverse");
            Console.WriteLine("5. Back");
            Console.Write("Select option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Enter number to enqueue: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        try { queue.Enqueue(num); Console.WriteLine("Enqueued!"); }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }

                    Console.WriteLine("\nPress 'A' to add another, or any other key to go back to Queue menu...");
                    var again = Console.ReadKey();
                    if (again.KeyChar != 'A' && again.KeyChar != 'a')
                        break;
                }
            }
            else if (choice == "2")
            {
                Console.Clear();
                try
                {
                    int val = queue.Dequeue();
                    Console.WriteLine($"Dequeued: {val}");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                Console.Clear();
                try
                {
                    int val = queue.Peek();
                    Console.WriteLine($"Peek: {val}");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                Console.ReadKey();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Queue contents (Front to Rear):");
                queue.Traverse();
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}