namespace UserManagement.Application.Common.Models
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }

    }
}
