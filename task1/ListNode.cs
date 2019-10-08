using System.Collections;


    class ListNode: Node, IEnumerable
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddNode(int newNodeValue)
        {
            Node node = new Node();
            node.Insert(newNodeValue);

            if (Head != null)
                Tail.Next = node;
            else
                Head = node;

            Tail = node;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Iterator();
        }

        IEnumerator Iterator()
        {
            Node current = Head;
                
            while (current != null)
            {
                yield return current.Value;
                current = (Node)current.Next;
            }
        }
    }

