using GO4.NET.Console._3_Behavioral._2_Command.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._2_Command.Client
{
    public static class CommandClient
    {
        public static void Execute()
        {
            Invoker invoker = new();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
            invoker.DoSomethingImportant();
        }
    }
}
