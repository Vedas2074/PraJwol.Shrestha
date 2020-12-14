using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class DepartmentController : Controller
{
    public ActionResult Index()
    {
        
        // Object Initilizer Syntax
        DepartmentModel dep1 = new DepartmentModel(){ DepartmentName = "Staff-Department", DepartmentCode = 010, DepartmentStaffNumber = 55, DepartmentAvaiablity ='N'};
        DepartmentModel dep2 = new DepartmentModel(){ DepartmentName = "Finance-Department", DepartmentCode = 010, DepartmentStaffNumber = 55, DepartmentAvaiablity ='N'};
        DepartmentModel dep3 = new DepartmentModel(){ DepartmentName = "Head-Department", DepartmentCode = 010, DepartmentStaffNumber = 55, DepartmentAvaiablity ='N'};

        List<DepartmentModel> department = new List<DepartmentModel> {dep1, dep2, dep3};
        return View(department);
    }

}