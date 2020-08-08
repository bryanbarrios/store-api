using Store.API.Persistence.Contexts;

namespace Store.API.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext context;
        public BaseRepository(AppDbContext context)
        {
            this.context = context;
        }
    }
}