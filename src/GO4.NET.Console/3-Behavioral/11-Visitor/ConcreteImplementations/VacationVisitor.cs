using static System.Console;
namespace GO4.NET.Console._3_Behavioral._11_Visitor.ConcreteImplementations
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            employee.VacationDays += 3;
            WriteLine("{0} {1}'s new vacation days: {2}",
                employee.GetType().Name, employee.Name,
                employee.VacationDays);
        }
    }

}
