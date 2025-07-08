using Microsoft.AspNetCore.Mvc;

namespace EmployeeMS.Controllers
{
    public class DepartmentsController : Controller
    {
        public string List()
        {
            return "List of Department Controller";
        }
       
        public string Details()
        {
            return "Details of Department Controller";
        }
    }
}
