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
            _context.Employees.Add(new Employee { FirstName = "Natalia", LastName = "Ruiz", Salary = 2300000, isActive = true, HireDate = new DateTime(2021, 7, 14) });
            _context.Employees.Add(new Employee { FirstName = "Sebastián", LastName = "Jiménez", Salary = 2000000, isActive = false, HireDate = new DateTime(2019, 10, 5) });
            _context.Employees.Add(new Employee { FirstName = "Paula", LastName = "Cardona", Salary = 1800000, isActive = true, HireDate = new DateTime(2020, 3, 22) });
            _context.Employees.Add(new Employee { FirstName = "Andrés", LastName = "Gutiérrez", Salary = 2600000, isActive = true, HireDate = new DateTime(2022, 9, 9) });
            _context.Employees.Add(new Employee { FirstName = "Lucía", LastName = "Salazar", Salary = 3100000, isActive = true, HireDate = new DateTime(2023, 4, 2) });
            _context.Employees.Add(new Employee { FirstName = "Tomás", LastName = "Arias", Salary = 1900000, isActive = false, HireDate = new DateTime(2018, 6, 18) });
            _context.Employees.Add(new Employee { FirstName = "Gabriela", LastName = "Vargas", Salary = 2400000, isActive = true, HireDate = new DateTime(2020, 11, 30) });
            _context.Employees.Add(new Employee { FirstName = "Miguel", LastName = "Herrera", Salary = 2700000, isActive = true, HireDate = new DateTime(2021, 2, 25) });
            _context.Employees.Add(new Employee { FirstName = "Isabela", LastName = "Ortega", Salary = 2900000, isActive = true, HireDate = new DateTime(2022, 5, 19) });
            _context.Employees.Add(new Employee { FirstName = "Simón", LastName = "Ruiz", Salary = 2100000, isActive = false, HireDate = new DateTime(2017, 8, 11) });
            _context.Employees.Add(new Employee { FirstName = "Alejandra", LastName = "Cano", Salary = 3200000, isActive = true, HireDate = new DateTime(2019, 12, 3) });
            _context.Employees.Add(new Employee { FirstName = "David", LastName = "Suárez", Salary = 2500000, isActive = true, HireDate = new DateTime(2021, 1, 8) });
            _context.Employees.Add(new Employee { FirstName = "Sofía", LastName = "García", Salary = 3300000, isActive = true, HireDate = new DateTime(2023, 6, 21) });
            _context.Employees.Add(new Employee { FirstName = "Cristian", LastName = "Mejía", Salary = 1900000, isActive = false, HireDate = new DateTime(2016, 4, 13) });
            _context.Employees.Add(new Employee { FirstName = "Daniela", LastName = "Arango", Salary = 2600000, isActive = true, HireDate = new DateTime(2020, 10, 7) });
            _context.Employees.Add(new Employee { FirstName = "Mateo", LastName = "Vélez", Salary = 1750000, isActive = true, HireDate = new DateTime(2019, 5, 2) });
            _context.Employees.Add(new Employee { FirstName = "Angela", LastName = "Cárdenas", Salary = 2900000, isActive = true, HireDate = new DateTime(2022, 2, 12) });
            _context.Employees.Add(new Employee { FirstName = "Nicolás", LastName = "Ríos", Salary = 3100000, isActive = true, HireDate = new DateTime(2023, 3, 15) });
            _context.Employees.Add(new Employee { FirstName = "Juliana", LastName = "Montoya", Salary = 2000000, isActive = false, HireDate = new DateTime(2018, 7, 25) });
            _context.Employees.Add(new Employee { FirstName = "Esteban", LastName = "Zapata", Salary = 2700000, isActive = true, HireDate = new DateTime(2020, 9, 9) });
            _context.Employees.Add(new Employee { FirstName = "Valeria", LastName = "Castaño", Salary = 2800000, isActive = true, HireDate = new DateTime(2021, 11, 17) });
            _context.Employees.Add(new Employee { FirstName = "Camilo", LastName = "Mendoza", Salary = 1950000, isActive = true, HireDate = new DateTime(2019, 1, 6) });
            _context.Employees.Add(new Employee { FirstName = "Laura", LastName = "Sierra", Salary = 2400000, isActive = false, HireDate = new DateTime(2017, 3, 28) });
            _context.Employees.Add(new Employee { FirstName = "Juanita", LastName = "Pineda", Salary = 2550000, isActive = true, HireDate = new DateTime(2020, 12, 12) });
            _context.Employees.Add(new Employee { FirstName = "Mauricio", LastName = "Cortés", Salary = 2700000, isActive = true, HireDate = new DateTime(2021, 8, 20) });
            _context.Employees.Add(new Employee { FirstName = "Tatiana", LastName = "Hernández", Salary = 3300000, isActive = true, HireDate = new DateTime(2022, 4, 3) });
            _context.Employees.Add(new Employee { FirstName = "José", LastName = "Morales", Salary = 1800000, isActive = false, HireDate = new DateTime(2016, 9, 15) });
            _context.Employees.Add(new Employee { FirstName = "Melissa", LastName = "Velásquez", Salary = 2100000, isActive = true, HireDate = new DateTime(2021, 10, 27) });
            _context.Employees.Add(new Employee { FirstName = "Felipe", LastName = "Ocampo", Salary = 3400000, isActive = true, HireDate = new DateTime(2023, 1, 10) });
            _context.Employees.Add(new Employee { FirstName = "Lorena", LastName = "Quintero", Salary = 2000000, isActive = true, HireDate = new DateTime(2020, 2, 4) });
            _context.Employees.Add(new Employee { FirstName = "Andrés", LastName = "Navarro", Salary = 2300000, isActive = true, HireDate = new DateTime(2021, 9, 29) });
            _context.Employees.Add(new Employee { FirstName = "Catalina", LastName = "Giraldo", Salary = 2500000, isActive = false, HireDate = new DateTime(2018, 8, 22) });
            _context.Employees.Add(new Employee { FirstName = "Julián", LastName = "Correa", Salary = 3200000, isActive = true, HireDate = new DateTime(2023, 5, 18) });
            _context.Employees.Add(new Employee { FirstName = "Sara", LastName = "Restrepo", Salary = 1950000, isActive = true, HireDate = new DateTime(2020, 1, 25) });
            _context.Employees.Add(new Employee { FirstName = "Diego", LastName = "Bermúdez", Salary = 2100000, isActive = true, HireDate = new DateTime(2021, 3, 30) });
            _context.Employees.Add(new Employee { FirstName = "Mariana", LastName = "Maya", Salary = 2850000, isActive = true, HireDate = new DateTime(2022, 6, 8) });
            _context.Employees.Add(new Employee { FirstName = "Pedro", LastName = "Valencia", Salary = 2400000, isActive = false, HireDate = new DateTime(2017, 12, 1) });
            _context.Employees.Add(new Employee { FirstName = "Ximena", LastName = "León", Salary = 2600000, isActive = true, HireDate = new DateTime(2019, 9, 12) });
            _context.Employees.Add(new Employee { FirstName = "Ricardo", LastName = "Cruz", Salary = 3100000, isActive = true, HireDate = new DateTime(2022, 11, 6) });
            _context.Employees.Add(new Employee { FirstName = "Adriana", LastName = "Roldán", Salary = 2250000, isActive = true, HireDate = new DateTime(2021, 4, 15) });
            _context.Employees.Add(new Employee { FirstName = "Fernando", LastName = "Muñoz", Salary = 2600000, isActive = false, HireDate = new DateTime(2018, 10, 11) });
            _context.Employees.Add(new Employee { FirstName = "Liliana", LastName = "Espinosa", Salary = 2900000, isActive = true, HireDate = new DateTime(2020, 8, 23) });
            _context.Employees.Add(new Employee { FirstName = "Hernán", LastName = "Patiño", Salary = 3000000, isActive = true, HireDate = new DateTime(2022, 12, 14) });
            await _context.SaveChangesAsync();
        }
    }
}