using GO4.NET.Console._1_Creational._2_Builder.Client;
using GO4.NET.Console._1_Creational._2_Builder.ConcreteImplementations;
using GO4.NET.Console._1_Creational._3_FactoryMethod.Client;
using GO4.NET.Console._1_Creational._4_Prototype.Client;
using GO4.NET.Console._1_Creational._5_Singleton.Client;
using GO4.NET.Console._2_Structural._1_Adapter.Client;
using GO4.NET.Console._2_Structural._1_Adapter.ConcreteImplementations;
using GO4.NET.Console._2_Structural._2_Bridge.Client;
using GO4.NET.Console._2_Structural._3_Composite.Client;
using GO4.NET.Console._2_Structural._4_Decorator.Client;
using GO4.NET.Console._2_Structural._5_Facade.Client;
using GO4.NET.Console._2_Structural._6_Flyweight.Client;
using GO4.NET.Console._2_Structural._7_Proxy.Client;
using GO4.NET.Console._3_Behavioral._1_ChainOfResponsibility.Client;
using GO4.NET.Console._3_Behavioral._2_Command.Client;
using GO4.NET.Console._3_Behavioral._3_Interpreter.Client;
using GO4.NET.Console._3_Behavioral._4_Iterator.Client;
using GO4.NET.Console._3_Behavioral._5_Mediator.Client;
using GO4.NET.Console._3_Behavioral._6_Memento.Client;
using GO4.NET.Console._3_Behavioral._7_Observer.Client;

#region 1-AbstractFactory
//var clientDb = new ClientDB(new PlayersMemoryDB());
//clientDb.Write();
//clientDb.Read();
#endregion 1-AbstractFactory

#region 2-Builder
//ClientRequest clientRequest = new ClientRequest(new HTTPRequestBuilder(), "http://my-api.com/api/v1/");
//clientRequest.RequestNoAuth("getData");
#endregion

#region 3-FactoryMethod
//ClientDBProvider clientDBProvider = new();
//clientDBProvider.Connect();
//clientDBProvider.ExecQuery("SELECT * FROM CLIENT");
#endregion

#region 4-Prototype
//FormClient.GetForm();
#endregion

#region 5-Singleton
//RequestClient.Exec();
#endregion

#region 1-Adapter
//HomeApplianceClient clientBR = new(new TwoPinSocket(), "Oven");
//clientBR.TurnOn();
//clientBR.TurnOff();

//Console.WriteLine(new String('-', 40));

//HomeApplianceClient europeanClient = new(new Adapter(new ThreePinSocket()), "Microwave");
//europeanClient.TurnOn();
//europeanClient.TurnOff();
#endregion

#region 2-Bridge
//SenderMessagesClient senderClient = new();
//senderClient.Send();
#endregion

#region 3-Composite
//ScreenClient.BuildScreen();
#endregion

#region 4-Decorator
//MenuClient.ShowMenuItens();
#endregion

#region 5-Facade
//PaymentClient.PayOrders();
#endregion

#region 6-Flyweight
//FlyweightClient.Show();
#endregion

#region 7-Proxy
//new DocumentClient().Print();
#endregion

//#region 1-ChainOfResponsibility
//AuthorizationClient.AuthorizePaidTimeOff();
//#endregion

#region 2-Command
//CommandClient.Execute();
#endregion

//#region 3-Interpreter
//InterpretClient.Interpret();
//#endregion 

#region 4-Iterator
//IteratorClient.Iterate();
#endregion

#region 5-Mediator
//MediatorClient.Run();
#endregion

//#region 6-Memento
//CalculatorClient.Calculate();
//#endregion

#region 7-Observer
ObserverClient.Observe();
#endregion

Console.ReadLine();