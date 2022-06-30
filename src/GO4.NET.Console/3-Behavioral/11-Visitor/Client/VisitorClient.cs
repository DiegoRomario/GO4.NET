using GO4.NET.Console._3_Behavioral._11_Visitor.ConcreteImplementations;
namespace GO4.NET.Console._3_Behavioral._11_Visitor.Client
{
    public static class VisitorClient
    {
        public static void Run()
        {
            Employees employee = new Employees();
            employee.Attach(new Clerk());
            employee.Attach(new Director());
            employee.Attach(new President());
            employee.Accept(new IncomeVisitor());
            employee.Accept(new VacationVisitor());
        }
    }
}
