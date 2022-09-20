using BugApplication.RepositoryInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugInfrastructure.DataAccess.Repos
{
    public class ProgramatorDbRepo : IProgramatorRepo
    {
        private readonly BugsContext _bugsContext;

        public ProgramatorDbRepo(BugsContext bugsContext)
        {
            _bugsContext = bugsContext;
        }

        public async Task<Programator> GetByUsernameAndPassword(string username, string password)
        {
            var dbAngajat = await _bugsContext.Employees.SingleOrDefaultAsync(
                a => a.Username == username && a.Password == password);
            if (dbAngajat == null)
                return null;
            var programator = EntityUtils.DBAngajatToAngajat(dbAngajat) as Programator;
            return programator;
        }
    }
}
