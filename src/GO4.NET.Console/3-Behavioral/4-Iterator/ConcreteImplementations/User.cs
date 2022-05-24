namespace GO4.NET.Console._3_Behavioral._4_Iterator.ConcreteImplementations
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
