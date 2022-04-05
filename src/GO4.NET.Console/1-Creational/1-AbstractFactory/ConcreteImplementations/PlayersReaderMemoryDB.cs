using static System.Console;

namespace GO4.NET.Console._1_Creational._1_AbstractFactory.ConcreteImplementations
{
    public class PlayersReaderMemoryDB : IPlayersReader
    {
        public void Read()
        {
            WriteLine("Reading from memory db");
        }
    }
}
