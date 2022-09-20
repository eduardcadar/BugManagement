using Domain.Entities;

namespace BugApplication.RepositoryInterfaces
{
    public interface IVerificatorRepo
    {
        Task<Verificator> GetByUsernameAndPassword(string username, string password);
    }
}
