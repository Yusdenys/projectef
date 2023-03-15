using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectef.Models
{
    public class Task
    {
        public Guid? TaskId { get; set; }
        public Guid CategoryId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Priority PriorityTask { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual Category? Category { get; set; }
        public string? Resume { get; set; }
        public string? Owner { get; set; }
    }

    public enum Priority 
    {
        Low,
        Medium,
        High
    }
}
