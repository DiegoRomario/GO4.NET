namespace GO4.NET.Console._3_Behavioral._4_Iterator.ConcreteImplementations
{
    public class Iterator : IAbstractIterator
    {
        private readonly int step = 1;
        private int current = 0;

        private ConcreteCollection collection;

        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public User First()
        {
            current = 0;
            return collection.GetUser(current);
        }

        public User Next()
        {
            current += step;
            if (!IsDone)
            {
                return collection.GetUser(current);
            }
            else
            {
                return null;
            }
        }

        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
