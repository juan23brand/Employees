using Employees.Backend.Data;
using Employees.Backend.Helpers;
using Employees.Backend.Repositories.Interfaces;
using Employees.Shared.DTOs;
using Employees.Shared.Entities;
using Employees.Shared.Responses;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Employees.Backend.Repositories.Implementations;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    private readonly DataContext _context;

    public EmployeeRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<ActionResponse<Employee>> GetAsync(int id)
    {
        var employee = await _context.Employees
             .FirstOrDefaultAsync(e => e.Id == id);

        if (employee == null)
        {
            return new ActionResponse<Employee>
            {
                WasSuccess = false,
                Message = "El empleado no existe"
            };
        }

        return new ActionResponse<Employee>
        {
            WasSuccess = true,
            Result = employee
        };
    }

    public override async Task<ActionResponse<IEnumerable<Employee>>> GetAsync(PaginationDTO pagination)
    {
        var queryable = _context.Employees
            .AsQueryable();

        return new ActionResponse<IEnumerable<Employee>>
        {
            WasSuccess = true,
            Result = await queryable
                .OrderBy(x => x.FirstName)
                .ThenBy(e => e.LastName)
                .Paginate(pagination)
                .ToListAsync()
        };
    }
}