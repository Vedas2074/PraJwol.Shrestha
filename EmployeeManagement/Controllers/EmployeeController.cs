using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Person.GetEmployees();
        return View(employees);
        
    }

    public ActionResult Detail(string FirstName)
    {
        var employees = Person.GetEmployees();
        Person employee = employees.FirstOrDefault(x=>x.FirstName == FirstName);
        return View(employee);

    }
    public ActionResult Add()   
    {
    return View();
    }

[HttpPost]
    public ActionResult<string> Add(Person person)
    {
        return "Record Saved";
    }

}




