using static System.Console;
namespace GO4.NET.Console._3_Behavioral._2_Command.ConcreteImplementations
{
    public class Receiver
    {
        public void DoSomething(string a)
        {
            WriteLine($"Receiver: Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            WriteLine($"Receiver: Also working on ({b}.)");
        }
    }
}
