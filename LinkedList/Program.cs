namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Programe");

            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Press 1 for create a linked List");
            Console.WriteLine("Press 2 for Add node at first in  linked List");
            Console.WriteLine("Press 3 to append node at last in linked List");
            Console.WriteLine("Press 4 to add node inbetween linked List");
            Console.WriteLine("Press 5 delete first node in  linked List");
            Console.WriteLine("Press 6 delete last node in  linked List");
            Console.WriteLine("Press 7 search the node  linked List");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                case 2:
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();
                    break;
                case 3:
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                case 4:
                    linkedList.AddLast(56);
                    linkedList.AddLast(70);
                    linkedList.InsertInBetween(30, 56);
                    linkedList.Display();
                    break ;
                case 5:
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    linkedList.DeleteFirst();
                    linkedList.Display();
                    break ;
                case 6:
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    linkedList.DeleteLast();
                    linkedList.Display();
                    break;
                    case 7:
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    Console.WriteLine("Searching 30");
                    linkedList.SearchElement(30);
                    break;
                default:
                    Console.WriteLine("Wrong selection");
                    break;

            }
        }
    }
}