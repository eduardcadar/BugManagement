using Domain.Entities;

namespace BugApplication.RepositoryInterfaces
{
    public interface IBugRepo
    {
        Task<Bug> Add(Bug bug);
        Task<IEnumerable<Bug>> GetAll();
        Task Update(Bug bug);
    }
}
