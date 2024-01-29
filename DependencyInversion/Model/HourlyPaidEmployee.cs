namespace DependencyInversion.Model;

public class HourlyPaidEmployee : IEmployee
{
    private string m_firstname;
    private string m_lastname;
    private double m_hourSalary;
    private int m_hours;

    public HourlyPaidEmployee(string firstname, string lastname, double hourSalary)
    {
        m_firstname = firstname;
        m_lastname = lastname;
        m_hourSalary = hourSalary;
        m_hours = 0;
    }

    public void AddHours(int hours)
    {
        m_hours += hours;
    }
    
    public double GetSalary()
    {
        return m_hourSalary * m_hours;
    }

    public string GetShortDetails()
    {
        return m_firstname + " " + m_lastname;
    }
}