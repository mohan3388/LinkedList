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
