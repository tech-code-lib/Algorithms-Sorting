using System;

namespace InsertionSortLinkedList
{
    public class Node
    {
        public int val;
        public Node next;

        public Node(int _val)
        {
            val = _val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(5);
            node.next = new Node(15);
            node.next.next = new Node(12);
            node.next.next.next = new Node(1);
            node.next.next.next.next = new Node(3);

            Print(node);
            Node sortedHeader = InsertionSort(node);
            Print(sortedHeader);
        }

        // 5 15 12

        static Node InsertionSort(Node node)
        {
            Node sortedHeader = null;
            Node current = node;

            while (current != null)
            {
                Node next = current.next;

                sortedHeader = InsertSorted(sortedHeader, current);
                
                current = next;
            }


            return sortedHeader;
        }

        static Node InsertSorted(Node sortedHeader, Node newNode)
        {
            if (sortedHeader == null || sortedHeader.val > newNode.val)
            {
                newNode.next = sortedHeader;
                return newNode;
            }
            else
            {
                Node current = sortedHeader;

                while (current.next != null && current.next.val < newNode.val)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
            return sortedHeader;
        }
        static void Print(Node node)
        {
            Node current = node;

            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }

            Console.WriteLine("");
        }
    }
}
