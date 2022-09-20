using BugApplication.RepositoryInterfaces;
using Domain.Entities;

namespace BugApplication.Services
{
    public class ServicePasBug
    {
        private readonly IPasBugRepo _pasBugRepo;

        public ServicePasBug(IPasBugRepo pasBugRepo)
        {
            _pasBugRepo = pasBugRepo;
        }

        public async Task<PasBug> AddPasBug(Bug bug, int pasNumber, string description) =>
            await _pasBugRepo.Add(new PasBug() {
                Bug = bug, PasNumber = pasNumber, Description = description });

        public async Task<IEnumerable<PasBug>> GetPasiBug(Bug bug) =>
            await _pasBugRepo.GetByBug(bug);

        public async Task<PasBug> UpdatePasBug(PasBug pasBug) =>
            await _pasBugRepo.UpdateBug(pasBug);

        public async Task DeletePasBug(Bug bug, int pasNumber) =>
            await _pasBugRepo.DeletePasBug(bug, pasNumber);
    }
}
