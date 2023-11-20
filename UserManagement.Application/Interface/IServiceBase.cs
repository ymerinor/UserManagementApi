using UserManagement.Domain.Repository.Interface;

namespace UserManagement.Application.Interface
{
    internal interface IServiceBase<TEntidad, TEntidadID> : IRepositoryBase<TEntidad, TEntidadID>, IList<TEntidad, TEntidadID>
    {
    }
}
