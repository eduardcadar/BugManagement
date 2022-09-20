using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BugInfrastructure.DBEntities
{
    public class DBBug
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public BugStatus Status { get; set; }
        public string Review { get; set; }
        public ICollection<DBPasBug> Steps { get; set; }
    }
}
