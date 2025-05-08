using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMangment.BLL.Interface;
using TodoMangment.DAL.Database;
using TodoMangment.DAL.Entite;

namespace TodoMangment.BLL.Repository
{
    public class TodoRepo : ITodoRepo
    {
        private readonly TodoDbContext _todoDb;

        public TodoRepo(TodoDbContext todoDb)
        {
            _todoDb = todoDb;
        }

        public async Task<IEnumerable<Todo>> GetAllAsync(string? status = null)
        {
            var query = _todoDb.Todos.AsQueryable();

            if (!string.IsNullOrEmpty(status) &&
                Enum.TryParse<Status>(status, true, out var parsedStatus))
            {
                query = query.Where(t => t.Status == parsedStatus);
            }

            return await query.ToListAsync();


        }
        public async Task<Todo> GetByIdAsync(Guid id)
        {
            return await _todoDb.Todos.FindAsync(id);
        }
        public async Task<Todo> AddAsync(Todo todo)
        {
            todo.Id = Guid.NewGuid();
           todo.CreatedDate = DateTime.Now;
            todo.LastModifiedDate = DateTime.Now;
            _todoDb.Todos.Add(todo);
            await _todoDb.SaveChangesAsync();
            return todo;
        }

        public async Task<Todo?> UpdateAsync(Todo todo)
        {
            var existing = await _todoDb.Todos.FindAsync(todo.Id);
            if (existing == null) return null;

            existing.Title = todo.Title;
            existing.Description = todo.Description;
            existing.Status = todo.Status;
            existing.Priority = todo.Priority;
            existing.DueDate = todo.DueDate;
            existing.LastModifiedDate = DateTime.Now;

            await _todoDb.SaveChangesAsync();
            return existing;
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            var todo = await _todoDb.Todos.FindAsync(id);
            if (todo == null) return false;
            _todoDb.Todos.Remove(todo);
            await _todoDb.SaveChangesAsync();
            return true;
        }



    }
}
