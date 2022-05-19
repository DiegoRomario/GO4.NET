namespace GO4.NET.Console._3_Behavioral._3_Interpreter.ConcreteImplementations
{
    public class Year : IExpression
    {
        public void Interpret(Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}
