using Domain.Entities;

namespace BugApplication.RepositoryInterfaces
{
    public interface IPasBugRepo
    {
        Task<PasBug> Add(PasBug pasBug);
        Task<IEnumerable<PasBug>> GetByBug(Bug bug);
        Task<PasBug> UpdateBug(PasBug pasBug);
        Task DeletePasBug(Bug bug, int pasNumber);
    }
}
