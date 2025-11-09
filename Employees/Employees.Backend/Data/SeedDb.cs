using Employees.Shared.Entities;
using Microsoft.EntityFrameworkCore;

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
        await CheckCountriesFullAsync();
    }

    private async Task CheckEmployeesAsync()
    {
        if (!_context.Employees.Any())
        {
            _context.Employees.Add(new Employee { Name = "Carolina", LastName = "Gómez", Salary = 1500000, isActive = true, HireDate = new DateTime(2020, 5, 10) });
            _context.Employees.Add(new Employee { Name = "Juan", LastName = "Pérez", Salary = 2200000, isActive = true, HireDate = new DateTime(2019, 3, 15) });
            _context.Employees.Add(new Employee { Name = "María", LastName = "Rodríguez", Salary = 1800000, isActive = false, HireDate = new DateTime(2018, 11, 2) });
            _context.Employees.Add(new Employee { Name = "Andrés", LastName = "Ramírez", Salary = 2500000, isActive = true, HireDate = new DateTime(2021, 1, 20) });
            _context.Employees.Add(new Employee { Name = "Laura", LastName = "Martínez", Salary = 3000000, isActive = true, HireDate = new DateTime(2022, 6, 5) });
            _context.Employees.Add(new Employee { Name = "Felipe", LastName = "Torres", Salary = 1700000, isActive = false, HireDate = new DateTime(2017, 9, 30) });
            _context.Employees.Add(new Employee { Name = "Camila", LastName = "Moreno", Salary = 2100000, isActive = true, HireDate = new DateTime(2021, 12, 12) });
            _context.Employees.Add(new Employee { Name = "Santiago", LastName = "Castro", Salary = 2800000, isActive = true, HireDate = new DateTime(2020, 8, 18) });
            _context.Employees.Add(new Employee { Name = "Valentina", LastName = "López", Salary = 1600000, isActive = true, HireDate = new DateTime(2023, 2, 7) });
            _context.Employees.Add(new Employee { Name = "Daniel", LastName = "Fernández", Salary = 3500000, isActive = false, HireDate = new DateTime(2016, 4, 25) });
            _context.Employees.Add(new Employee { Name = "Natalia", LastName = "Ruiz", Salary = 2300000, isActive = true, HireDate = new DateTime(2021, 7, 14) });
            _context.Employees.Add(new Employee { Name = "Sebastián", LastName = "Jiménez", Salary = 2000000, isActive = false, HireDate = new DateTime(2019, 10, 5) });
            _context.Employees.Add(new Employee { Name = "Paula", LastName = "Cardona", Salary = 1800000, isActive = true, HireDate = new DateTime(2020, 3, 22) });
            _context.Employees.Add(new Employee { Name = "Andrés", LastName = "Gutiérrez", Salary = 2600000, isActive = true, HireDate = new DateTime(2022, 9, 9) });
            _context.Employees.Add(new Employee { Name = "Lucía", LastName = "Salazar", Salary = 3100000, isActive = true, HireDate = new DateTime(2023, 4, 2) });
            _context.Employees.Add(new Employee { Name = "Tomás", LastName = "Arias", Salary = 1900000, isActive = false, HireDate = new DateTime(2018, 6, 18) });
            _context.Employees.Add(new Employee { Name = "Gabriela", LastName = "Vargas", Salary = 2400000, isActive = true, HireDate = new DateTime(2020, 11, 30) });
            _context.Employees.Add(new Employee { Name = "Miguel", LastName = "Herrera", Salary = 2700000, isActive = true, HireDate = new DateTime(2021, 2, 25) });
            _context.Employees.Add(new Employee { Name = "Isabela", LastName = "Ortega", Salary = 2900000, isActive = true, HireDate = new DateTime(2022, 5, 19) });
            _context.Employees.Add(new Employee { Name = "Simón", LastName = "Ruiz", Salary = 2100000, isActive = false, HireDate = new DateTime(2017, 8, 11) });
            _context.Employees.Add(new Employee { Name = "Alejandra", LastName = "Cano", Salary = 3200000, isActive = true, HireDate = new DateTime(2019, 12, 3) });
            _context.Employees.Add(new Employee { Name = "David", LastName = "Suárez", Salary = 2500000, isActive = true, HireDate = new DateTime(2021, 1, 8) });
            _context.Employees.Add(new Employee { Name = "Sofía", LastName = "García", Salary = 3300000, isActive = true, HireDate = new DateTime(2023, 6, 21) });
            _context.Employees.Add(new Employee { Name = "Cristian", LastName = "Mejía", Salary = 1900000, isActive = false, HireDate = new DateTime(2016, 4, 13) });
            _context.Employees.Add(new Employee { Name = "Daniela", LastName = "Arango", Salary = 2600000, isActive = true, HireDate = new DateTime(2020, 10, 7) });
            _context.Employees.Add(new Employee { Name = "Mateo", LastName = "Vélez", Salary = 1750000, isActive = true, HireDate = new DateTime(2019, 5, 2) });
            _context.Employees.Add(new Employee { Name = "Angela", LastName = "Cárdenas", Salary = 2900000, isActive = true, HireDate = new DateTime(2022, 2, 12) });
            _context.Employees.Add(new Employee { Name = "Nicolás", LastName = "Ríos", Salary = 3100000, isActive = true, HireDate = new DateTime(2023, 3, 15) });
            _context.Employees.Add(new Employee { Name = "Juliana", LastName = "Montoya", Salary = 2000000, isActive = false, HireDate = new DateTime(2018, 7, 25) });
            _context.Employees.Add(new Employee { Name = "Esteban", LastName = "Zapata", Salary = 2700000, isActive = true, HireDate = new DateTime(2020, 9, 9) });
            _context.Employees.Add(new Employee { Name = "Valeria", LastName = "Castaño", Salary = 2800000, isActive = true, HireDate = new DateTime(2021, 11, 17) });
            _context.Employees.Add(new Employee { Name = "Camilo", LastName = "Mendoza", Salary = 1950000, isActive = true, HireDate = new DateTime(2019, 1, 6) });
            _context.Employees.Add(new Employee { Name = "Laura", LastName = "Sierra", Salary = 2400000, isActive = false, HireDate = new DateTime(2017, 3, 28) });
            _context.Employees.Add(new Employee { Name = "Juanita", LastName = "Pineda", Salary = 2550000, isActive = true, HireDate = new DateTime(2020, 12, 12) });
            _context.Employees.Add(new Employee { Name = "Mauricio", LastName = "Cortés", Salary = 2700000, isActive = true, HireDate = new DateTime(2021, 8, 20) });
            _context.Employees.Add(new Employee { Name = "Tatiana", LastName = "Hernández", Salary = 3300000, isActive = true, HireDate = new DateTime(2022, 4, 3) });
            _context.Employees.Add(new Employee { Name = "José", LastName = "Morales", Salary = 1800000, isActive = false, HireDate = new DateTime(2016, 9, 15) });
            _context.Employees.Add(new Employee { Name = "Melissa", LastName = "Velásquez", Salary = 2100000, isActive = true, HireDate = new DateTime(2021, 10, 27) });
            _context.Employees.Add(new Employee { Name = "Felipe", LastName = "Ocampo", Salary = 3400000, isActive = true, HireDate = new DateTime(2023, 1, 10) });
            _context.Employees.Add(new Employee { Name = "Lorena", LastName = "Quintero", Salary = 2000000, isActive = true, HireDate = new DateTime(2020, 2, 4) });
            _context.Employees.Add(new Employee { Name = "Andrés", LastName = "Navarro", Salary = 2300000, isActive = true, HireDate = new DateTime(2021, 9, 29) });
            _context.Employees.Add(new Employee { Name = "Catalina", LastName = "Giraldo", Salary = 2500000, isActive = false, HireDate = new DateTime(2018, 8, 22) });
            _context.Employees.Add(new Employee { Name = "Julián", LastName = "Correa", Salary = 3200000, isActive = true, HireDate = new DateTime(2023, 5, 18) });
            _context.Employees.Add(new Employee { Name = "Sara", LastName = "Restrepo", Salary = 1950000, isActive = true, HireDate = new DateTime(2020, 1, 25) });
            _context.Employees.Add(new Employee { Name = "Diego", LastName = "Bermúdez", Salary = 2100000, isActive = true, HireDate = new DateTime(2021, 3, 30) });
            _context.Employees.Add(new Employee { Name = "Mariana", LastName = "Maya", Salary = 2850000, isActive = true, HireDate = new DateTime(2022, 6, 8) });
            _context.Employees.Add(new Employee { Name = "Pedro", LastName = "Valencia", Salary = 2400000, isActive = false, HireDate = new DateTime(2017, 12, 1) });
            _context.Employees.Add(new Employee { Name = "Ximena", LastName = "León", Salary = 2600000, isActive = true, HireDate = new DateTime(2019, 9, 12) });
            _context.Employees.Add(new Employee { Name = "Ricardo", LastName = "Cruz", Salary = 3100000, isActive = true, HireDate = new DateTime(2022, 11, 6) });
            _context.Employees.Add(new Employee { Name = "Adriana", LastName = "Roldán", Salary = 2250000, isActive = true, HireDate = new DateTime(2021, 4, 15) });
            _context.Employees.Add(new Employee { Name = "Fernando", LastName = "Muñoz", Salary = 2600000, isActive = false, HireDate = new DateTime(2018, 10, 11) });
            _context.Employees.Add(new Employee { Name = "Liliana", LastName = "Espinosa", Salary = 2900000, isActive = true, HireDate = new DateTime(2020, 8, 23) });
            _context.Employees.Add(new Employee { Name = "Hernán", LastName = "Patiño", Salary = 3000000, isActive = true, HireDate = new DateTime(2022, 12, 14) });
            await _context.SaveChangesAsync();
        }
    }

    private async Task CheckCountriesFullAsync()
    {
        if (!_context.Countries.Any())
        {
            var countriesSQLScript = File.ReadAllText("Data\\CountriesStatesCities.sql");
            await _context.Database.ExecuteSqlRawAsync(countriesSQLScript);
        }
    }
}