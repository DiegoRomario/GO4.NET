namespace GO4.NET.Console._3_Behavioral._4_Iterator.ConcreteImplementations
{
    public class ConcreteCollection : IAbstractCollection
    {
        private readonly List<User> userList = new();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return userList.Count; }
        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public User GetUser(int position)
        {
            return userList[position];
        }
    }
}