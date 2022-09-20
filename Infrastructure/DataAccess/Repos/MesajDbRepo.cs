using BugApplication.RepositoryInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugInfrastructure.DataAccess.Repos
{
    public class MesajDbRepo : IMesajRepo
    {
        private readonly BugsContext _bugsContext;

        public MesajDbRepo(BugsContext bugsContext)
        {
            _bugsContext = bugsContext;
        }

        public async Task<Mesaj> Add(Mesaj message)
        {
            var dbMesaj = EntityUtils.MesajToDBMesaj(message);
            await _bugsContext.Messages.AddAsync(dbMesaj);
            await _bugsContext.SaveChangesAsync();
            message.Id = dbMesaj.Id;
            return message;
        }

        public async Task<IEnumerable<Mesaj>> GetBySenderAndReceiver(Angajat sender, Angajat receiver)
        {
            var messages = await _bugsContext.Messages
                .Where(m => m.SenderId == sender.Id && m.ReceiverId == receiver.Id)
                .Select(m => EntityUtils.DBMesajToMesaj(m))
                .ToListAsync();
            return messages;
        }
    }
}
