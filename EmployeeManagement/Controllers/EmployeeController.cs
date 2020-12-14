using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        
        // Object Initilizer Syntax
        Person employee1 = new Person(){ FirstName = "PraJwol", LastName = "Shrestha", Address = "Lamatar", Gender ='M'};
        Person employee2 = new Person(){ FirstName = "Nick", LastName = "Shrestha", Address = "London", Gender ='M'};
        Person employee3 = new Person(){ FirstName = "Sam", LastName = "Shrestha", Address = "USA", Gender ='M'};

        List<Person> employee = new List<Person> {employee1, employee2, employee3};
        return View(employee);
    }

}




