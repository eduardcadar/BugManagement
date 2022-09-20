using Domain.Entities;
using BugInfrastructure.DBEntities;

namespace BugInfrastructure
{
    public static class EntityUtils
    {
        public static Angajat DBAngajatToAngajat(DBAngajat dbAngajat)
        {
            return new Angajat(dbAngajat.Name, dbAngajat.Username, dbAngajat.Password, dbAngajat.IsTester)
            {
                Id = dbAngajat.Id
            };
        }

        public static DBBug BugToDBBug(Bug bug)
        {
            return new DBBug
            {
                Id = bug.Id,
                Description = bug.Description,
                Status = bug.Status,
                Review = bug.Review
            };
        }

        public static DBMesaj MesajToDBMesaj(Mesaj message)
        {
            return new DBMesaj
            {
                Id = message.Id,
                SenderId = message.Sender.Id,
                ReceiverId = message.Receiver.Id,
                Text = message.Text,
                SentAt = message.SentAt
            };
        }

        public static Mesaj DBMesajToMesaj(DBMesaj m)
        {
            var sender = DBAngajatToAngajat(m.Sender);
            var receiver = DBAngajatToAngajat(m.Receiver);
            return new Mesaj()
            {
                Id = m.Id,
                Sender = sender,
                Receiver = receiver,
                Text = m.Text,
                SentAt = m.SentAt
            };
        }

        public static DBAngajat AngajatToDBAngajat(Angajat angajat)
        {
            return new DBAngajat
            {
                Id = angajat.Id,
                Name = angajat.Name,
                Username = angajat.Username,
                Password = angajat.Password,
                IsTester = angajat.IsTester
            };
        }

        public static DBPasBug PasBugToDBPasBug(PasBug pasBug)
        {
            return new DBPasBug
            {
                BugId = pasBug.Bug.Id,
                PasNumber = pasBug.PasNumber,
                Description = pasBug.Description
            };
        }

        public static Bug DBBugToBug(DBBug dbBug)
        {
            return new Bug()
            {
                Id = dbBug.Id,
                Description = dbBug.Description,
                Status = dbBug.Status,
                Review = dbBug.Review
            };
        }

        public static PasBug DBPasBugToPasBug(DBPasBug p)
        {
            var bug = DBBugToBug(p.Bug);
            return new PasBug()
            {
                Bug = bug,
                PasNumber = p.PasNumber,
                Description = p.Description
            };
        }
    }
}
