namespace ConsoleApp2;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public List<Project> Projects { get; set; } = new();
}