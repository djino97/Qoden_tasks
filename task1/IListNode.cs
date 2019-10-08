
    public interface IListNode
    {
        int Value { get; set; }
        IListNode Next { get; set; }

        void Insert(int newValue);
    }
