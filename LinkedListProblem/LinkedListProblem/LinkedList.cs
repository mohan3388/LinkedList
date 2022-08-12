using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("inserted data: " + node.data);
            }

        }
        public void Append(int data)
        {
            Node node = new Node(data);
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            Console.WriteLine(node.data + " Append data");
        }
        public int Search(int addedData)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == addedData)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public Node InsertData(int position, int data)
        {
            Node node2 = new Node(data);
            if (this.head == null)
            {
                return node2;
            }
            if (position == 0)
            {
                node2.next = head;
                head = node2;
                return head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            node2.next = prev.next;
            prev.next = node2;
            return this.head;
        }
        public void DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Link list is empty");
            }
            Node temp = this.head;
            this.head = this.head.next;
        }
        public Node DeleteLastElement()

        {
            if (head == null)
            {
                return null;
            }
            Node node = head;
            while (node.next.next != null)
            {
                node = node.next;
            }
            node.next = null;
            return head;


        }
        public void DeleteNodeParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty");

            }
            Node temp = head;
            if (position == 0)
            {
                this.head = temp.next;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = null;
        }
        public void LinkedListSize()
        {
            Node temp = this.head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Linked list size " + count);
        }
          public void SortOrderList()
        {
            Node current = head, index = null;
            Node temp;
            if (head == null)
            {
                return;
            }

            while (current != null)
            {
                index = current.next;
                while (index != null)
                {
                    if (current.data.CompareTo(index.data) > 0)
                    {
                        temp = current.data;
                        current.data = index.data;
                        index.data = temp;
                    }
                    index = index.next;
                }
                current = current.next;
            }
            Display();
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }

    }
}
