using static System.Console;

namespace GO4.NET.Console._3_Behavioral._2_Command.ConcreteImplementations
{
    public class SimpleCommand : ICommand
    {
        private readonly string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
        }
    }
}
