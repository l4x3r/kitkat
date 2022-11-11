namespace BlazorApp.Data
{
    public interface IKitKatService
    {
        Task LoadKitKatEaters();
        Task Create(KitKatEater eater);
        List<KitKatEater> KitKatEaters { get; set; }
    }
}