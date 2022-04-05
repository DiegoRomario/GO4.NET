namespace GO4.NET.Console._1_Creational._1_AbstractFactory.Client
{
    public class ClientDB
    {
        private IPlayersDBAbstractFactory _playersDBAbstractFactory;

        public ClientDB(IPlayersDBAbstractFactory playersDBAbstractFactory)
        {
            _playersDBAbstractFactory = playersDBAbstractFactory;
        }

        public void Read()
        {
            _playersDBAbstractFactory.ReadPlayers().Read();
        }

        public void Write()
        {
            _playersDBAbstractFactory.WritePlayers().Write();
        }

    }
}
