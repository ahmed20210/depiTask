namespace ConsoleApp2;

using System.Collections.Generic;
using System.Linq;

public class EmployeeService
{
    private readonly ApplicationDbContext _context;

    public EmployeeService()
    {
        _context = new ApplicationDbContext();
        _context.Database.EnsureCreated();
    }

    public List<Employee> GetAllEmployees()
    {
        return _context.Employees.ToList();
    }

    public Employee? GetEmployeeById(int id)
    {
        return _context.Employees.Find(id);
    }

    public void AddEmployee(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
    }

    public void UpdateEmployee(Employee employee)
    {
        _context.Employees.Update(employee);
        _context.SaveChanges();
    }

    public void DeleteEmployee(int id)
    {
        var employee = _context.Employees.Find(id);
        if (employee != null)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
    }
}
