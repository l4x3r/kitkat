using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class KitKatService : IKitKatService
    {
        private readonly KitKatDbContext _context;
        public KitKatService(KitKatDbContext context)
        {
            _context = context;
        }

        public List<KitKatEater> KitKatEaters { get; set; } = new List<KitKatEater>();

        public async Task LoadKitKatEaters()
        {
            KitKatEaters = await _context.KitKatEaters.ToListAsync();
        }
    }
}