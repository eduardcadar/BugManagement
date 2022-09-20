using BugApplication.RepositoryInterfaces;
using Domain.Entities;

namespace BugApplication.Services
{
    public class ServiceMesaj
    {
        private readonly IMesajRepo _mesajRepo;

        public ServiceMesaj(IMesajRepo mesajRepo)
        {
            _mesajRepo = mesajRepo;
        }

        public async Task<Mesaj> AddMesaj(Angajat sender, Angajat receiver,
            string text, DateTime sentAt) => await _mesajRepo.Add(new Mesaj()
                { Sender = sender, Receiver = receiver, Text = text, SentAt = sentAt });

        public async Task<IEnumerable<Mesaj>> GetMesajeBetween(Angajat ang1, Angajat ang2)
        {
            var mesaje = new List<Mesaj>();
            mesaje.AddRange(await _mesajRepo.GetBySenderAndReceiver(ang1, ang2));
            mesaje.AddRange(await _mesajRepo.GetBySenderAndReceiver(ang2, ang1));
            return mesaje;
        }
    }
}
