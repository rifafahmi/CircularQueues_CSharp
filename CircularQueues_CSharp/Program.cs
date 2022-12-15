using System;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                if (REAR == max - 1)
                    REAR = 0;
                else
                    REAR = REAR + 1;
            }
            queue_array[REAR] = element;
        }
        public void remove()
        {
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[FRONT] + "\n");
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_positition = FRONT;
            int REAR_positition = REAR;

            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are........\n");
            if (FRONT_positition <= REAR_positition)
            {
                while (FRONT_positition <= REAR_positition)
                {
                    Console.WriteLine(queue_array[FRONT_positition] + "   ");
                    FRONT_positition++;
                }
                Console.WriteLine();
            }
            else
            {
                while (FRONT_positition <= max - 1)
                {
                    Console.WriteLine(queue_array[FRONT_positition] + "   ");
                    FRONT_positition++;
                }
                FRONT_positition = 0;
                while (FRONT_positition <= REAR_positition)
                {
                    Console.Write(queue_array[FRONT_positition] + "   ");
                    FRONT_positition++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu ");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("1. Implement delete operation");
                    Console.WriteLine("3. Display values ");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\n Enter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("\nEnter a number: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
