namespace OpenClose
{
    public class EmployeeContrator : Employee
    {
        public EmployeeContrator(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 40000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}