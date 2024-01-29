using DependencyInversion.Model;

namespace DependencyInversion.Serivce;

public class SalaryProcessor
{
    private IEmployee m_employee;

    public SalaryProcessor(IEmployee employee)
    {
        m_employee = employee;
    }

    public void PaySalary()
    {
       Console.WriteLine("Employee " + m_employee.GetShortDetails() + "is paid" + m_employee.GetSalary());
    }
}