using System.ComponentModel.DataAnnotations;

namespace Third_Task.Models
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
