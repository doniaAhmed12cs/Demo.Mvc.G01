using Microsoft.AspNetCore.Mvc;

namespace Demo.pl.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentReposatory _departmentReposatory;

        public DepartmentController(IDepartmentReposatory departmentReposatory)
        {
            _departmentReposatory = departmentReposatory;
        }
        public IActionResult Index()
        {
            var department = _departmentReposatory.GetAll();
            return View();
        }
    }
}
