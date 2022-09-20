using Domain.Entities;

namespace BugApplication.RepositoryInterfaces
{
    public interface IAngajatRepo
    {
        Task<Angajat> GetByUsernameAndPassword(string username, string password);
        Task<IEnumerable<Angajat>> GetAll();
    }
}
