using Microsoft.AspNetCore.Mvc;
using Entity_FreamWork.Models;

namespace Entity_FreamWork.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HR_Database_Context dbContext = new HR_Database_Context();

        // عرض كل الموظفين
        public IActionResult Index()
        {

            List<Employes> model = dbContext.Employesses.ToList();
            return View("Employee", model);
            //var employees = GetEmployesses();
            //return View(SortEmployees(employees, SortField, CurrentField, SortDiration));
        }



        public List<Employes> GetEmployesses()
        {
            var Employes = (from Employess in dbContext.Employesses
                            join DepartMents in dbContext.DepartMents on Employess.DepartmentID equals DepartMents.DepartmentID
                            select new Employes
                            {
                                Employee_Id = Employess.Employee_Id,
                                Employee_Name = Employess.Employee_Name,
                                Employee_Number = Employess.Employee_Number,
                                DOB = Employess.DOB,
                                Hiriring_Date = Employess.Hiriring_Date,
                                Gross_Salary = Employess.Gross_Salary,
                                NetSalary = Employess.NetSalary,
                                DepartmentID = Employess.DepartmentID,
                               

                            }).ToList();

            return Employes;
        }

        // عرض صفحة الإنشاء
        public IActionResult Create()
        {
            ViewBag.DepartmentList = dbContext.DepartMents.ToList();
            return View();
        }

        // عرض صفحة التعديل بنفس فورم الإنشاء

        // حفظ الموظف الجديد
        [HttpPost]


        public IActionResult Create(Employes model)
        {
            ModelState.Remove("Employee ID");
            ModelState.Remove("Department"); 
            if (ModelState.IsValid)
            {
                dbContext.Employesses.Add(model);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentList = this.dbContext.DepartMents.ToList();
            return View();
        }

        public IActionResult Edit(int id)
        {
            var employee = dbContext.Employesses.FirstOrDefault(e => e.Employee_Id == id);
            if (employee == null)
                return NotFound();

            ViewBag.DepartmentList = dbContext.DepartMents.ToList();
            return View("Create", employee);
        }

        [HttpPost]

        public IActionResult Edit(Employes model)
        {
            if (ModelState.IsValid)
            {
                dbContext.Employesses.Update(model);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentList = dbContext.DepartMents.ToList();
            return View("Create", model);
        }

        public IActionResult Delete(int id)
        {
            var employee = dbContext.Employesses.FirstOrDefault(e => e.Employee_Id == id);
            if (employee != null)
            {
                dbContext.Employesses.Remove(employee);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");

        }


        //public List<Employes> SortEmployees(List<Employes> employees, string sortField, string currentField, string sortDirection)
        //{
        //    if (string.IsNullOrEmpty(sortField))
        //    {
        //        ViewBag.CurrentField = currentField;
        //        ViewBag.SortDirection = "Asc";
        //    }
        //    else
        //    {
        //        if (currentField == sortField)
        //        {
        //            ViewBag.SortDirection = sortDirection == "Asc" ? "Desc" : "Asc";
        //        }
        //        else
        //        {
        //            ViewBag.CurrentField = sortField;
        //            ViewBag.SortDirection = "Asc";
        //        }
        //    }

        //    var sortedEmployees = typeof(Employes).GetProperty(ViewBag.sortField);
        //    if (ViewBag.SortDirection == "Asc")
        //    {
        //        return employees.OrderBy(e => sortedEmployees.GetValue(e, null)).ToList();
        //    }
        //    else
        //    {
        //        return employees.OrderByDescending(e => sortedEmployees.GetValue(e, null)).ToList();
        //    }
        //    return employees; // Return the original list if no sorting is applied  


        //}

    }
}
