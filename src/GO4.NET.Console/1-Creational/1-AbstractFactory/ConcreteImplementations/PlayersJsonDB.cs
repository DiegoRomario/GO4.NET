namespace GO4.NET.Console._1_Creational._1_AbstractFactory.ConcreteImplementations
{
    public class PlayersJsonDB : IPlayersDBAbstractFactory
    {
        public IPlayersReader ReadPlayers()
        {
            return new PlayersReaderJsonDB();
        }

        public IPlayersWriter WritePlayers()
        {
            return new PlayersWriteJsonDB();
        }
    }
}
