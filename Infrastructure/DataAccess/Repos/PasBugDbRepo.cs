using BugApplication.RepositoryInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugInfrastructure.DataAccess.Repos
{
    public class PasBugDbRepo : IPasBugRepo
    {
        private readonly BugsContext _bugsContext;

        public PasBugDbRepo(BugsContext bugsContext)
        {
            _bugsContext = bugsContext;
        }

        public async Task<PasBug> Add(PasBug pasBug)
        {
            var dbPasBug = EntityUtils.PasBugToDBPasBug(pasBug);
            await _bugsContext.Steps.AddAsync(dbPasBug);
            await _bugsContext.SaveChangesAsync();
            return pasBug;
        }

        public async Task DeletePasBug(Bug bug, int pasNumber)
        {
            var dbPasBug = await _bugsContext.Steps
                .SingleOrDefaultAsync(p => p.BugId == bug.Id && p.PasNumber == pasNumber);
            if (dbPasBug == null) return;
            _bugsContext.Steps
                .Remove(dbPasBug);
            await _bugsContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<PasBug>> GetByBug(Bug bug)
        {
            var pasiBug = await _bugsContext.Steps
                .Where(p => p.BugId == bug.Id)
                .Select(p => EntityUtils.DBPasBugToPasBug(p))
                .ToListAsync();
            return pasiBug;
        }

        public async Task<PasBug> UpdateBug(PasBug pasBug)
        {
            var dbPasBug = await _bugsContext.Steps.
                SingleOrDefaultAsync(p => p.BugId == pasBug.Bug.Id && p.PasNumber == pasBug.PasNumber);
            if (dbPasBug == null) return null;
            dbPasBug.Description = pasBug.Description;
            await _bugsContext.SaveChangesAsync();
            return pasBug;
        }
    }
}
