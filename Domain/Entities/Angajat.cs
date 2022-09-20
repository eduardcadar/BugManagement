namespace Domain.Entities
{
    public class Angajat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsTester { get; set; }

        public Angajat(string name, string username, string password, bool isTester)
        {
            Name = name;
            Username = username;
            Password = password;
            IsTester = isTester;
        }

        internal void Validate()
        {
            if (!string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("Introdu nume");
            if (!string.IsNullOrWhiteSpace(Username))
                throw new ArgumentException("Introdu username");
            if (!string.IsNullOrWhiteSpace(Password))
                throw new ArgumentException("Introdu parola");
        }
    }
}
