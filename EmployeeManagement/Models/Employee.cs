using System.Collections.Generic;

public class Employee
{
    public string FirstName {get; set; }
    public string LastName {get; set; }
    public string Address {get; set; }
    public char Gender {get; set; }
    public int Salary {get; set; } = 10000; // asssigned default value

    public List<Employee> GetEmployees()
{
    // Object Initilizer Syntax
       var employee1 = new Employee(){ FirstName = "PraJwol", LastName = "Shrestha", Address = "Lamatar", Gender ='M'};
        var employee2 = new Employee(){ FirstName = "Nick", LastName = "Shrestha", Address = "London", Gender ='M'};
        var employee3 = new Employee(){ FirstName = "Sam", LastName = "Shrestha", Address = "USA", Gender ='M'};

        var employees = new List<Employee> {employee1, employee2, employee3};
        return employees;
}
}
