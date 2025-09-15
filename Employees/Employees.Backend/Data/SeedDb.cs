using Employees.Shared.Entities;

namespace Employees.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedDbAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckEmployeesAsync();
    }

    private async Task CheckEmployeesAsync()
    {
        if (!_context.Employees.Any())
        {
            _context.Employees.Add(new Employee { FirstName = "Carolina", LastName = "Gomez", Salary = 2000000 });
            _context.Employees.Add(new Employee { FirstName = "Carolina", LastName = "Gómez", Salary = 1500000, isActive = true, HireDate = new DateTime(2020, 5, 10) });
            _context.Employees.Add(new Employee { FirstName = "Juan", LastName = "Pérez", Salary = 2200000, isActive = true, HireDate = new DateTime(2019, 3, 15) });
            _context.Employees.Add(new Employee { FirstName = "María", LastName = "Rodríguez", Salary = 1800000, isActive = false, HireDate = new DateTime(2018, 11, 2) });
            _context.Employees.Add(new Employee { FirstName = "Andrés", LastName = "Ramírez", Salary = 2500000, isActive = true, HireDate = new DateTime(2021, 1, 20) });
            _context.Employees.Add(new Employee { FirstName = "Laura", LastName = "Martínez", Salary = 3000000, isActive = true, HireDate = new DateTime(2022, 6, 5) });
            _context.Employees.Add(new Employee { FirstName = "Felipe", LastName = "Torres", Salary = 1700000, isActive = false, HireDate = new DateTime(2017, 9, 30) });
            _context.Employees.Add(new Employee { FirstName = "Camila", LastName = "Moreno", Salary = 2100000, isActive = true, HireDate = new DateTime(2021, 12, 12) });
            _context.Employees.Add(new Employee { FirstName = "Santiago", LastName = "Castro", Salary = 2800000, isActive = true, HireDate = new DateTime(2020, 8, 18) });
            _context.Employees.Add(new Employee { FirstName = "Valentina", LastName = "López", Salary = 1600000, isActive = true, HireDate = new DateTime(2023, 2, 7) });
            _context.Employees.Add(new Employee { FirstName = "Daniel", LastName = "Fernández", Salary = 3500000, isActive = false, HireDate = new DateTime(2016, 4, 25) });
            await _context.SaveChangesAsync();
        }
    }
}