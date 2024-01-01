using System.ComponentModel.DataAnnotations;

namespace GenericController.Entities
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public Guid UID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
