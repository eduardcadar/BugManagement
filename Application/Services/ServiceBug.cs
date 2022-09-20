using BugApplication.RepositoryInterfaces;
using Domain.Entities;

namespace BugApplication.Services
{
    public class ServiceBug
    {
        private readonly IBugRepo _bugRepo;

        public ServiceBug(IBugRepo bugRepo)
        {
            _bugRepo = bugRepo;
        }

        public async Task<Bug> AddBug(string description) =>
            await _bugRepo.Add(new Bug() { Description = description, Status = BugStatus.ADAUGAT, Review = "" });

        public async Task<IEnumerable<Bug>> GetAllBugs() =>
            await _bugRepo.GetAll();

        public async Task UpdateBug(Bug newBug) =>
            await _bugRepo.Update(newBug);
    }
}
