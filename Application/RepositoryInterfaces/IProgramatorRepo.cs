using Domain.Entities;

namespace BugApplication.RepositoryInterfaces
{
    public interface IProgramatorRepo
    {
        Task<Programator> GetByUsernameAndPassword(string username, string password);
    }
}
