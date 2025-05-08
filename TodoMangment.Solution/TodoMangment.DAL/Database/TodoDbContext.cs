using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMangment.DAL.Entite;

namespace TodoMangment.DAL.Database
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options):base(options) { }

            public DbSet<Todo> Todos { get; set; }    
                
    }
}
