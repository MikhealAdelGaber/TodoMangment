using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMangment.DAL.Entite
{
    public enum Status{
        Pending =0 , InProgress = 1  , Completed =2
    };
    public enum Priority
    {
        Low = 0 , Medium = 1 , High = 2
    };


    public class Todo
    {
        public Guid Id { get; set; } = new Guid();
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; } = Status.Pending;
        public Priority Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime LastModifiedDate { get; set; }
    }
}
