using Employees.Backend.Repositories.Interfaces;
using Employees.Backend.UnitsOfWork.Interfaces;
using Employees.Shared.DTOs;
using Employees.Shared.Entities;
using Employees.Shared.Responses;
using System.Diagnostics.Metrics;

namespace Employees.Backend.UnitsOfWork.Implementations;

public class EmployeeUnitOfWork : GenericUnitOfWork<Employee>, IEmployeeUnitOfWork
{
    private readonly IEmployeeRepository _employeesRepository;

    public EmployeeUnitOfWork(IGenericRepository<Employee> repository, IEmployeeRepository employeeRepository) : base(repository)
    {
        _employeesRepository = employeeRepository;
    }

    public override async Task<ActionResponse<IEnumerable<Employee>>> GetAsync() => await _employeesRepository.GetAsync();

    public override async Task<ActionResponse<Employee>> GetAsync(int id) => await _employeesRepository.GetAsync(id);

    public override async Task<ActionResponse<IEnumerable<Employee>>> GetAsync(PaginationDTO pagination) => await _employeesRepository.GetAsync(pagination);

    public override async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination) => await _employeesRepository.GetTotalRecordsAsync(pagination);
}