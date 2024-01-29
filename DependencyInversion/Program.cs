// See https://aka.ms/new-console-template for more information

using DependencyInversion.Model;
using DependencyInversion.Serivce;

void Main(string[] args)
{
    var hourlyPaidEmployee = new HourlyPaidEmployee("john", "bradley", 20);
    var monthlyPaidEmployee = new MonthlyPaidEmployee("maria", "smith", 1234);

    List <SalaryProcessor> salaryProcessors= new List<SalaryProcessor>();
    salaryProcessors.Add(new SalaryProcessor(hourlyPaidEmployee));
    salaryProcessors.Add(new SalaryProcessor(monthlyPaidEmployee));

    foreach (var salaryProcessor in salaryProcessors)
    {
        salaryProcessor.PaySalary();
    }
}

