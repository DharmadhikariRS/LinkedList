namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Programe");

            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Press 1 for create a linked List");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Wrong selection");
                    break;

            }
        }
    }
}