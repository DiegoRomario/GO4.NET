using static System.Console;
using GO4.NET.Console._3_Behavioral._4_Iterator.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._4_Iterator.Client
{
    public static class IteratorClient
    {
        public static void Iterate()
        {
            ConcreteCollection collection = new();

            collection.AddUser(new User("Joey", 10));
            collection.AddUser(new User("Johnny", 11));
            collection.AddUser(new User("Tommy", 12));
            collection.AddUser(new User("Dee Dee", 13));
            collection.AddUser(new User("Mark", 14));

            Iterator iterator = collection.CreateIterator();

            WriteLine("Hit any key to continue");
            ReadKey();
            WriteLine("Iterating over users :\n ");

            for (User user = iterator.First(); !iterator.IsDone; user = iterator.Next())
            {
                WriteLine($"ID: {user.Id} & Name: {user.Name}");
            }

        }
    }
}
