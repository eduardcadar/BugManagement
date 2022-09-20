namespace Domain.Entities
{
    public class Programator : Angajat
    {
        public Programator(string nume, string username, string password, bool isTester) : base(nume, username, password, isTester)
        {
        }

        public Programator(Angajat angajat) : base(angajat.Name, angajat.Username, angajat.Password, angajat.IsTester)
        {
        }

        public ReviewBug CreateReviewBug(Bug bug, string text)
            => new(bug, text);
    }
}
