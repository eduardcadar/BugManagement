using BugApplication.RepositoryInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugInfrastructure.DataAccess.Repos
{
    public class VerificatorDbRepo : IVerificatorRepo
    {
        private readonly BugsContext _bugsContext;

        public VerificatorDbRepo(BugsContext bugsContext)
        {
            _bugsContext = bugsContext;
        }

        public async Task<Verificator> GetByUsernameAndPassword(string username, string password)
        {
            var dbAngajat = await _bugsContext.Employees.SingleOrDefaultAsync(
                a => a.Username == username && a.Password == password);
            if (dbAngajat == null)
                return null;
            var verificator = EntityUtils.DBAngajatToAngajat(dbAngajat) as Verificator;
            return verificator;
        }
    }
}
