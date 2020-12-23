using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    [Required(ErrorMessage="This field is Required")]
    public string FirstName {get; set; }
    public string LastName {get; set; }
    public string Address {get; set; }
    public char Gender {get; set; }
    public double? Salary {get; set; } = 10000; // asssigned default value

public static List<Person> GetEmployees()

{// Object Initilizer Syntax
        Person employee1 = new Person(){ FirstName = "PraJwol", LastName = "Shrestha", Address = "Lamatar", Gender ='M'};
        Person employee2 = new Person(){ FirstName = "Nick", LastName = "Shrestha", Address = "London", Gender ='M'};
        Person employee3 = new Person(){ FirstName = "Sam", LastName = "Shrestha", Address = "USA", Gender ='M'};

        List<Person> employee = new List<Person> {employee1, employee2, employee3};
        return employee;

}
}