namespace Domain.Entities
{
    public class Mesaj
    {
        public int Id { get; set; }
        public Angajat Sender { get; set; }
        public Angajat Receiver { get; set; }
        public string Text { get; set; }
        public DateTime SentAt { get; set; }
    }
}
