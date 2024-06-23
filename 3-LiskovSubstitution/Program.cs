using Liskov;

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 1, 5),
    new EmployeeContractor("Manuel Lopera", 1)
});

void CalculateSalaryMonthly(List<Employee> employees)
{
    foreach (var item in employees)
    {
        decimal salary = item.CalculateSalary();
        Console.WriteLine($"The {item.Fullname}'s salary is {salary}");
    }
}