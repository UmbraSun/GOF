namespace GOF_Patterns.Iterator
{
    public class DataStack
    {
        private int[] items = new int[10];
        private int length;

        public DataStack() => length = -1;
        public DataStack(DataStack stack)
        {
            this.items = stack.items;
            this.length = stack.length;
        }

        public int[] Items { get => items; }
        public int Length { get => length; }

        public void Push(int value) => Items[++length] = value;
        public int Pop() => Items[length--];

        public static bool operator ==(DataStack stack1, DataStack stack2)
        {
            StackIterator it1 = new StackIterator(stack1);
            StackIterator it2 = new StackIterator(stack2);

            while(it1.IsEnd() || it2.IsEnd())
            {
                if (it1.Get() != it2.Get()) break;
                it1++;
                it2++;
            }

            return !it1.IsEnd() && !it2.IsEnd();
        }

        public static bool operator !=(DataStack stack1, DataStack stack2)
        {
            StackIterator it1 = new StackIterator(stack1);
            StackIterator it2 = new StackIterator(stack2);

            while (it1.IsEnd() || it2.IsEnd())
            {
                if (it1.Get() != it2.Get()) break;
                it1++;
                it2++;
            }

            return !(!it1.IsEnd() && !it2.IsEnd());
        }
    }
}
