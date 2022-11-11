namespace BlazorApp.Data
{
    public interface IKitKatService
    {
        Task LoadKitKatEaters();
        List<KitKatEater> KitKatEaters { get; set; }
    }
}