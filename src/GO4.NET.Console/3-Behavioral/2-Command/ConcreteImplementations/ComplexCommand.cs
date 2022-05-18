using static System.Console;
namespace GO4.NET.Console._3_Behavioral._2_Command.ConcreteImplementations
{
    public class ComplexCommand : ICommand
    {
        private readonly Receiver _receiver;

        private readonly string _a;

        private readonly string _b;
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }
        public void Execute()
        {
            WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }
}
