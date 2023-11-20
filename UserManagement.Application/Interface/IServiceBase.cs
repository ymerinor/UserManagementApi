using UserManagement.Domain.Repository.Interface;

namespace UserManagement.Application.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntidad"></typeparam>
    /// <typeparam name="TEntidadID"></typeparam>
    public interface IServiceBase<TEntidad, TEntidadID> : IRepositoryBase<TEntidad, TEntidadID>, IList<TEntidad, TEntidadID>
    {
    }
}
