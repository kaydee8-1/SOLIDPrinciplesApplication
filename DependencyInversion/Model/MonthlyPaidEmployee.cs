namespace DependencyInversion.Model;

public class MonthlyPaidEmployee : IEmployee
{
    private string m_firstname;
    private string m_lastname;
    private double m_Salary;

    public MonthlyPaidEmployee(string firstname, string lastname, double Salary)
    {
        m_firstname = firstname;
        m_lastname = lastname;
        m_Salary = Salary;
    }
    public double GetSalary()
    {
       return m_Salary;   
    }

    public string GetShortDetails()
    {
        return m_firstname + " " + m_lastname;
    }
}