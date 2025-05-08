using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMangment.DAL.Entite;

namespace TodoMangment.BLL.Interface
{
    public interface ITodoRepo
    {
        Task<IEnumerable<Todo>> GetAllAsync(string? status =null);
        Task<Todo> GetByIdAsync(Guid id);

        Task<Todo> AddAsync(Todo todo);
        Task<Todo?> UpdateAsync(Todo todo);
        Task<bool> DeleteAsync(Guid id);



    }
}
