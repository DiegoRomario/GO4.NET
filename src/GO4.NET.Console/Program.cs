using GO4.NET.Console._1_Creational._2_Builder.Client;
using GO4.NET.Console._1_Creational._2_Builder.ConcreteImplementations;
using GO4.NET.Console._1_Creational._3_FactoryMethod.Client;

#region 1-AbstractFactory
//var clientDb = new ClientDB(new PlayersMemoryDB());
//clientDb.Write();
//clientDb.Read();
#endregion 1-AbstractFactory

#region 2-Builder
//ClientRequest clientRequest = new ClientRequest(new HTTPRequestBuilder(), "http://my-api.com/api/v1/");
//clientRequest.RequestNoAuth("getData");
#endregion

ClientDBProvider clientDBProvider = new();
clientDBProvider.Connect();
clientDBProvider.ExecQuery("SELECT * FROM CLIENT");

Console.ReadLine();