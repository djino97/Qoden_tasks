

    class HashTable : IHashTable
    {

        public IListNode[] Values { get; set; }
        int key;
        ListNode List { get; set; }

        public HashTable(int size)
        {
           Values = new IListNode[size];
        }

        public void ExtensionsHasTable(int xi, int n)
        {
            int newKey = GetHash(n, xi);

            if (Values.Length > newKey)
                key = newKey;
            else
            {
                IListNode[] newValues = new IListNode[newKey + 1];
                key = newKey;

                for (int i = 0; i < Values.Length; i++)
                    newValues[i] = Values[i];
                Values = newValues;
            }
  
        }

        private int GetHash(int n, int xi)
        {
            return xi % n;
        }

        public void Insert(int xi)
        {
            if (Values[key] == null)
               List = new ListNode();
            else
                List = (ListNode)Values[key];

            List.AddNode(xi);

            Values[key] = List;
        }
            
    }
