using static System.Console;

namespace GO4.NET.Console._1_Creational._1_AbstractFactory.ConcreteImplementations
{
    public class PlayersWriteMemoryDB : IPlayersWriter
    {
        public void Write()
        {
            WriteLine("Writing in memory db");
        }
    }
}
