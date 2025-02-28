using System;

namespace ConsoleApp2;
class Program
{
    static void Main()
    {
        var service = new EmployeeService();

        while (true)
        {
            Console.WriteLine("\n==== Employee Management ====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee(service);
                    break;
                case "2":
                    ViewEmployees(service);
                    break;
                case "3":
                    UpdateEmployee(service);
                    break;
                case "4":
                    DeleteEmployee(service);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddEmployee(EmployeeService service)
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine()!;
        
        Console.Write("Enter Position: ");
        string position = Console.ReadLine()!;

        Console.Write("Enter Salary: ");
        decimal salary = decimal.Parse(Console.ReadLine()!);

        Console.Write("Enter Hire Date (yyyy-mm-dd): ");
        DateTime hireDate = DateTime.Parse(Console.ReadLine()!);

        Console.Write("Enter Department ID: ");
        int departmentId = int.Parse(Console.ReadLine()!);

        var employee = new Employee
        {
            Name = name,
            Position = position,
            Salary = salary,
            HireDate = hireDate,
            DepartmentId = departmentId
        };

        service.AddEmployee(employee);
        Console.WriteLine("Employee added successfully!");
    }

    static void ViewEmployees(EmployeeService service)
    {
        var employees = service.GetAllEmployees();

        Console.WriteLine("\n==== Employee List ====");
        foreach (var e in employees)
        {
            Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Position: {e.Position}, Salary: {e.Salary}, Hire Date: {e.HireDate.ToShortDateString()}, Department ID: {e.DepartmentId}");
        }
    }

    static void UpdateEmployee(EmployeeService service)
    {
        Console.Write("Enter Employee ID to update: ");
        int id = int.Parse(Console.ReadLine()!);

        var employee = service.GetEmployeeById(id);
        if (employee == null)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        Console.Write("Enter New Name: ");
        employee.Name = Console.ReadLine()!;

        Console.Write("Enter New Position: ");
        employee.Position = Console.ReadLine()!;

        Console.Write("Enter New Salary: ");
        employee.Salary = decimal.Parse(Console.ReadLine()!);

        service.UpdateEmployee(employee);
        Console.WriteLine("Employee updated successfully!");
    }

    static void DeleteEmployee(EmployeeService service)
    {
        Console.Write("Enter Employee ID to delete: ");
        int id = int.Parse(Console.ReadLine()!);

        service.DeleteEmployee(id);
        Console.WriteLine("Employee deleted successfully!");
    }
}
