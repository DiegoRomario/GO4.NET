namespace GO4.NET.Console._1_Creational._1_AbstractFactory.ConcreteImplementations
{
    public class PlayersMemoryDB : IPlayersDBAbstractFactory
    {
        public IPlayersReader ReadPlayers()
        {
            return new PlayersReaderMemoryDB();
        }

        public IPlayersWriter WritePlayers()
        {
            return new PlayersWriteMemoryDB();
        }
    }
}
