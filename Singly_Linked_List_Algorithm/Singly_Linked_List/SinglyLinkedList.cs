




using System;

namespace Singly_Linked_List
{
    public class SinglyLinkedList
    {
        public Node head { get; set; }
        public Node tail { get; set; }

        public int count { get; private set; }

        public void AddFirst(int value)
        {
            AddFirst(new Node(value));
        }
        private void AddFirst(Node node)
        {
            Node temp = head;
            head = node;
            head.next = temp;
            count++;
            if (count == 1)
            {
                tail = head;
            }
        }
        public void AddLast(int value)
        {
            AddLast(new Node(value));
        }
        private void AddLast(Node node)
        {
            if (IsEmpty)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }
            tail = node;
            count++;
        }
        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            head = head.next;
            if (count == 1)
            {
                tail = null;
            }
            count--;
        }
        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                Node current = head;
                while (current.next != tail)
                {
                    current = current.next;
                }
                current.next = null;
                tail = current;
            }
            count--;
        }
        private bool IsEmpty => count == 0;
    }
}
