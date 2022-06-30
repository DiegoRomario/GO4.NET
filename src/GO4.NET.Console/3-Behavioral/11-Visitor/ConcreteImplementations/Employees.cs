using static System.Console;
namespace GO4.NET.Console._3_Behavioral._11_Visitor.ConcreteImplementations
{
    public class Employees : Element
    {
        private readonly List<Employee> employees = new List<Employee>();
        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }
        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }
        public override void Accept(IVisitor visitor)
        {
            foreach (Employee employee in employees) employee.Accept(visitor);
            WriteLine();
        }
    }

}
