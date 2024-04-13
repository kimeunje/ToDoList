namespace ToDoList.Models
{
    public class LeadEntity
    {
        public int Id { get; set; }
        public DateTime LeadDate { get; set; }
        public required string LeadSource { get; set; }
        public required string Name { get; set; }
        public required string Mobile { get; set; }
        public required string Email { get; set; }
    }
}
