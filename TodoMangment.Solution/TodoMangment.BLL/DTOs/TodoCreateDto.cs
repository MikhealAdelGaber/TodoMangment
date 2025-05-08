using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMangment.DAL.Entite;

namespace TodoMangment.BLL.DTOs
{
    public class TodoCreateDto
    {
        [Required, MaxLength(100)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public Status Status { get; set; } = Status.Pending;

        public Priority Priority { get; set; } = Priority.Medium;

        public DateTime? DueDate { get; set; }
    }
}
