using Employees.Shared.DTOs;
using Employees.Shared.Entities;
using Employees.Shared.Responses;
using System.Diagnostics.Metrics;

namespace Employees.Backend.UnitsOfWork.Interfaces;

public interface IEmployeeUnitOfWork
{
    Task<ActionResponse<IEnumerable<Employee>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<Employee>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Employee>>> GetAsync();
    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}