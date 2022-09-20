using BugApplication.RepositoryInterfaces;
using Domain.Entities;

namespace BugApplication.Services
{
    public class ServiceAngajat
    {
        private readonly IAngajatRepo _angajatRepo;

        public ServiceAngajat(IAngajatRepo angajatRepo)
        {
            _angajatRepo = angajatRepo;
        }

        public async Task<Angajat> GetAngajatByUsernameAndPassword(string username, string password)
            => await _angajatRepo.GetByUsernameAndPassword(username, password);

        public async Task<IEnumerable<Angajat>> GetAllEmployees()
            => await _angajatRepo.GetAll();
    }
}
