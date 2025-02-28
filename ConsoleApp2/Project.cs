namespace ConsoleApp2;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public decimal Budget { get; set; }
    public List<Employee> Employees { get; set; } = new();
}