using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class KitKatService : IKitKatService
    {
        private readonly KitKatDbContext _context;
        private readonly NavigationManager _navigationManager;
        public KitKatService(KitKatDbContext context, NavigationManager navigationManager)
        {
            _context = context;
            _navigationManager = navigationManager;
        }

        public List<KitKatEater> KitKatEaters { get; set; } = new List<KitKatEater>();

        public async Task LoadKitKatEaters()
        {
            KitKatEaters = await _context.KitKatEaters.ToListAsync();
        }

         public async Task Create(KitKatEater eater)
        {
            _context.KitKatEaters.Add(eater);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("toplist");
        }
    }
}