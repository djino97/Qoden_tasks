using System;


    class Program
    {
        static void Main(string[] args)
        {
            HashTable newHashTable = new HashTable(1);

            var N = Console.ReadLine();
            var xi = Console.ReadLine().Split(' ');

            ListNode listNode;

            foreach (var val in xi)
            {
                newHashTable.ExtensionsHasTable(int.Parse(val), int.Parse(N));
                newHashTable.Insert(int.Parse(val));
            }

            for (int i=0; i< newHashTable.Values.Length; i++)
            {
                Console.WriteLine("\n");
                Console.Write(i + ":");

                listNode = (ListNode)newHashTable.Values[i];

                if (listNode != null)
                {
                    foreach (int xki in listNode)
                        Console.Write(" " + xki);
                }
            }

            Console.WriteLine("\n");
        }
    }
