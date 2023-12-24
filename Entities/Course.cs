namespace GenericController.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
    }
}
