namespace Domain.Entities
{
    public class Verificator : Angajat
    {
        public Verificator(string nume, string username, string password, bool isTester) : base(nume, username, password, isTester)
        {
        }

        public Verificator(Angajat angajat) : base(angajat.Name, angajat.Username, angajat.Password, angajat.IsTester)
        {
        }
    }
}
