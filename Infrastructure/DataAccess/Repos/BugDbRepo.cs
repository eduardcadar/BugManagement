using BugApplication.RepositoryInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugInfrastructure.DataAccess.Repos
{
    public class BugDbRepo : IBugRepo
    {
        private readonly BugsContext _bugsContext;

        public BugDbRepo(BugsContext bugsContext)
        {
            _bugsContext = bugsContext;
        }

        public async Task<Bug> Add(Bug bug)
        {
            var dbBug = EntityUtils.BugToDBBug(bug);
            await _bugsContext.Bugs.AddAsync(dbBug);
            await _bugsContext.SaveChangesAsync();
            bug.Id = dbBug.Id;
            return bug;
        }

        public async Task<IEnumerable<Bug>> GetAll()
        {
            var bugs = await _bugsContext.Bugs
                .Select(b => EntityUtils.DBBugToBug(b))
                .ToListAsync();
            return bugs;
        }

        public async Task Update(Bug bug)
        {
            var dbBug = await _bugsContext.Bugs.
                SingleOrDefaultAsync(b => b.Id == bug.Id);
            if (dbBug != null)
            {
                dbBug.Description = bug.Description;
                dbBug.Status = bug.Status;
                dbBug.Review = bug.Review;
                await _bugsContext.SaveChangesAsync();
            }
        }
    }
}
