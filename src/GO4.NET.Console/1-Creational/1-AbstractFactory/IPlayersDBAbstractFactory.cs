namespace GO4.NET.Console._1_Creational._1_AbstractFactory
{
    public interface IPlayersDBAbstractFactory
    {
        IPlayersReader ReadPlayers();
        IPlayersWriter WritePlayers();
    }
}
