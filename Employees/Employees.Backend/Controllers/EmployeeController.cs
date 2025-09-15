using Employees.Backend.UnitsOfWork.Interfaces;
using Employees.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : GenericController<Employee>
    {
        public EmployeeController(IGenericUnitOfWork<Employee> UnitOfWork) : base(UnitOfWork)
        {
        }
    }
}