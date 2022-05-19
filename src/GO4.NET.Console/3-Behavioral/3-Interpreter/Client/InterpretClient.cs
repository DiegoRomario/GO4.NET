using static System.Console;
using GO4.NET.Console._3_Behavioral._3_Interpreter.ConcreteImplementations;

namespace GO4.NET.Console._3_Behavioral._3_Interpreter.Client
{
    public static class InterpretClient
    {
        public static void Interpret()
        {
            List<IExpression> expressions = new();
            Context context = new(DateTime.Now);
            WriteLine("Which format do you want?: MM-DD-YYYY, YYYY-MM-DD ou DD-MM-YYYY");

            context.Expression = ReadLine().ToUpper();

            string[] formato = context.Expression.Split("-");

            foreach (var item in formato)
            {
                if (item == "DD") expressions.Add(new Day());
                else if (item == "MM") expressions.Add(new Month());
                else if (item == "YYYY") expressions.Add(new Year());

            }

            expressions.Add(new Separator());

            foreach (var obj in expressions) obj.Interpret(context);

            WriteLine($"Date in chosen format: {context.Expression}");
        }
    }
}
