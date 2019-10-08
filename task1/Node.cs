using System;
using System.Collections.Generic;
using System.Linq;


    class Node : IListNode
    {
        public int Value { get; set; }
        public IListNode Next { get; set; }

        public void Insert(int newValue)
        {
            Value = newValue;
        }   
    }
