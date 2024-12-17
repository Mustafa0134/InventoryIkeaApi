using InventoryIkeaApi.Services.Interfaces;

namespace InventoryIkeaApi.Services
{
    public class PaginationService : IPaginationService
    {
        public IEnumerable<T> GetPage<T>(IEnumerable<T> source, int page, int pageSize, CancellationToken cancellationToken = default)
        {
            if (page < 1) throw new ArgumentException("Page number should be greater than 0.");
            if (pageSize < 1) throw new ArgumentException("Page size should be greater than 0.");

            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
