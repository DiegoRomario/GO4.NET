namespace GO4.NET.Console._3_Behavioral._3_Interpreter.ConcreteImplementations
{
    public class Context
    {
        public string Expression { get; set; }
        public DateTime Date { get; set; }

        public Context(DateTime date)
        {
            Date = date;
        }
    }
}
