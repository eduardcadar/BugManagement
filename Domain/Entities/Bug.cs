namespace Domain.Entities
{
    public class Bug
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public BugStatus Status { get; set; }
        public string Review { get; set; }
    }
}
