﻿using OpenClose;

void ShowSalaryMonthly(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly()} ");
    }

}

ShowSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 160),
    new EmployeeContrator("Juanito Prueba",160)
});