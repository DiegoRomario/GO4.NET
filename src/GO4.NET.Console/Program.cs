using GO4.NET.Console._1_Creational._1_AbstractFactory.Client;
using GO4.NET.Console._1_Creational._1_AbstractFactory.ConcreteImplementations;

var client = new ClientDB(new PlayersMemoryDB());
client.Write();
client.Read();

Console.ReadLine();