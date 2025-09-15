using Employees.Backend.Data;
using Employees.Backend.Repositories.Interfaces;
using Employees.Shared.Entities;
using Employees.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace Employees.Backend.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _entity;

        public GenericRepository(DataContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }

        public virtual async Task<ActionResponse<T>> AddAsync(T entity)
        {
            _context.Add(entity);
            try
            {
                await _context.SaveChangesAsync();
                return new ActionResponse<T>
                {
                    WasSuccess = true,
                    Result = entity
                };
            }
            catch (DbUpdateException)
            {
                return DbUpdateExceptionActionResponse();
            }
            catch (Exception ex)
            {
                return ExceptionActionResponse(ex);
            }
        }

        public virtual async Task<ActionResponse<T>> DeleteAsync(int id)
        {
            var row = await _entity.FindAsync(id);
            if (row == null)
            {
                return new ActionResponse<T>
                {
                    Message = "Registro no encontrado."
                };
            }
            _entity.Remove(row);
            try
            {
                await _context.SaveChangesAsync();
                return new ActionResponse<T>
                {
                    WasSuccess = true
                };
            }
            catch
            {
                return new ActionResponse<T>
                {
                    Message = "No se puede borrar porque tiene registros relacionados."
                };
            }
        }

        public virtual async Task<ActionResponse<IEnumerable<T>>> GetAsync()
        {
            return new ActionResponse<IEnumerable<T>>
            {
                WasSuccess = true,
                Result = await _entity.ToListAsync()
            };
        }

        public virtual async Task<ActionResponse<T>> GetAsync(int id)
        {
            var row = await _entity.FindAsync(id);
            if (row == null)
            {
                return new ActionResponse<T>
                {
                    Message = "Registro no encontrado."
                };
            }
            return new ActionResponse<T>
            {
                WasSuccess = true,
                Result = row
            };
        }

        public virtual async Task<ActionResponse<IEnumerable<T>>> GetAsync(string name)
        {
            if (typeof(T) == typeof(Employee))
            {
                var employees = await _context.Employees
                    .Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name))
                    .Cast<T>()
                    .ToListAsync();

                return new ActionResponse<IEnumerable<T>>
                {
                    WasSuccess = employees.Any(),
                    Result = employees,
                    Message = employees.Any() ? null : "No se encontraron registros."
                };
            }

            return new ActionResponse<IEnumerable<T>>
            {
                Message = "Búsqueda por nombre no soportada para esta entidad."
            };
        }

        public virtual async Task<ActionResponse<T>> UpdateAsync(T entity)
        {
            _context.Update(entity);
            try
            {
                await _context.SaveChangesAsync();
                return new ActionResponse<T>
                {
                    WasSuccess = true,
                    Result = entity
                };
            }
            catch (DbUpdateException)
            {
                return DbUpdateExceptionActionResponse();
            }
            catch (Exception ex)
            {
                return ExceptionActionResponse(ex);
            }
        }

        private ActionResponse<T> ExceptionActionResponse(Exception ex) => new ActionResponse<T>
        {
            Message = ex.Message
        };

        private ActionResponse<T> DbUpdateExceptionActionResponse() => new ActionResponse<T>
        {
            Message = "Ya existe el registro."
        };
    }
}