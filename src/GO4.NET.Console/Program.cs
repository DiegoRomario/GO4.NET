using GO4.NET.Console._1_Creational._2_Builder.Client;
using GO4.NET.Console._1_Creational._2_Builder.ConcreteImplementations;

#region 1-AbstractFactory
//var clientDb = new ClientDB(new PlayersMemoryDB());
//clientDb.Write();
//clientDb.Read();
//Console.ReadLine();
#endregion 1-AbstractFactory

ClientRequest clientRequest = new ClientRequest(new HTTPRequestBuilder(), "http://my-api.com/api/v1/");
clientRequest.RequestNoAuth("getData");
Console.ReadLine();