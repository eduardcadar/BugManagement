using System.ComponentModel.DataAnnotations;

namespace BugInfrastructure.DBEntities
{
    public class DBAngajat
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsTester { get; set; }
    }
}
