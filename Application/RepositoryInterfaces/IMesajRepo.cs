using Domain.Entities;

namespace BugApplication.RepositoryInterfaces
{
    public interface IMesajRepo
    {
        Task<Mesaj> Add(Mesaj message);
        Task<IEnumerable<Mesaj>> GetBySenderAndReceiver(Angajat sender, Angajat receiver);
    }
}
