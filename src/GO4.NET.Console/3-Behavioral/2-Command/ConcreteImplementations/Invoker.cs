using static System.Console;

namespace GO4.NET.Console._3_Behavioral._2_Command.ConcreteImplementations
{
    public class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;
        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }
        public void DoSomethingImportant()
        {
            WriteLine("Invoker: Does anybody want something done before I begin?");
            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            WriteLine("Invoker: ...doing something really important...");

            WriteLine("Invoker: Does anybody want something done after I finish?");
            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
}
