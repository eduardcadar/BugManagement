namespace BugInfrastructure.DBEntities
{
    public class DBPasBug
    {
        public int BugId { get; set; }
        public DBBug Bug { get; set; }
        public int PasNumber { get; set; }
        public string Description { get; set; }
    }
}
