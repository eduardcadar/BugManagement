using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugInfrastructure.DBEntities
{
    public class DBMesaj
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("SenderId")]
        public int SenderId { get; set; }
        public DBAngajat Sender { get; set; }
        [ForeignKey("ReceiverId")]
        public int ReceiverId { get; set; }
        public DBAngajat Receiver { get; set; }
        public string Text { get; set; }
        public DateTime SentAt { get; set; }
    }
}
