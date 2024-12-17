namespace InventoryIkeaApi.Services.Interfaces
{
    public interface IPaginationService
    {
        IEnumerable<T> GetPage<T>(IEnumerable<T> source, int page, int pageSize, CancellationToken cancellationToken = default);
    }
}
