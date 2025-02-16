using PTPMQL.Models;

namespace PTPMQL;

public class Employee : Person
{
    public string EmployeeID { get; set; }
    public int Age { get; set; }
    public Employee(string fullName, string employeeID, int age)

{
    EmployeeID = employeeID;
    Age = age;
}
}
