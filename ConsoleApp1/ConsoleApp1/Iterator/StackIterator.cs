namespace GOF_Patterns.Iterator
{
    public class StackIterator
    {
        private DataStack stack;
        private int index;

        public StackIterator(DataStack stack)
        {
            this.stack = stack;
            this.index = 0;
        }

        public static StackIterator operator ++(StackIterator s)
        {
            s.index++;
            return s;
        }

        public int Get()
        {
            if (index < stack.Length)
                return stack.Items[index];
            return 0;
        }

        public bool IsEnd() => index != stack.Length + 1;
    }
}
