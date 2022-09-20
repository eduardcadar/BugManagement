using BugApplication.RepositoryInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugInfrastructure.DataAccess.Repos
{
    public class AngajatDbRepo : IAngajatRepo
    {
        private readonly BugsContext _bugsContext;

        public AngajatDbRepo(BugsContext bugsContext)
        {
            _bugsContext = bugsContext;
        }

        public async Task<IEnumerable<Angajat>> GetAll()
        {
            var angajati = await _bugsContext.Employees
                .Select(a => EntityUtils.DBAngajatToAngajat(a))
                .ToListAsync();
            return angajati;
        }

        public async Task<Angajat> GetByUsernameAndPassword(string username, string password)
        {
            var dbAngajat = await _bugsContext.Employees.SingleOrDefaultAsync(
                a => a.Username == username && a.Password == password);
            if (dbAngajat == null)
                return null;
            var angajat = EntityUtils.DBAngajatToAngajat(dbAngajat);
            return angajat;
        }
    }
}
