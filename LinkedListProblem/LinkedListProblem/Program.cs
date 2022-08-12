namespace LinkedListProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to data structure program");
            LinkedList list = new LinkedList();
            Console.WriteLine("1. press 1 to display\n2. press 2 to display append data\n3. press 3 Insert data between to element\n4. press 4 to delete node data\n5.DeletLast Element in node");
            bool check = true;
            while (check)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Display add element");
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;
                    case 2:
                        Console.WriteLine("Append element");
                        list.Add(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        break;
                    case 3:
                        Console.WriteLine("Insert data between to element");
                        list.Add(56);
                        list.Add(70);
                        int a = list.Search(56);
                        list.InsertData(a + 1, 30);

                        list.Display();
                        break;
                    case 4:
                        Console.WriteLine("Delete first element in Node");
                        list.Add(56);
                        list.Add(70);
                        list.DeleteFirstNode();
                        list.Display();
                        break;
                    case 5:

                        Console.WriteLine("DeletLast Element in node");
                        list.Add(56);
                        list.Add(70);
                        list.DeleteLastElement();
                        list.Display();
                        break;
                    case 6:
                        Console.WriteLine("search element");
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);

                        int node = list.Search(70);
                        Console.WriteLine("data position " + node);
                        list.Display();
                        break;
                    default:
                        Console.WriteLine("press above key");
                        break;
                }
            }
        }
    }
}