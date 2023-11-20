namespace UserManagement.Domain.Repository.Interface
{
    public interface IRepositoryBase<TEntidad, TEntidadID> : IList<TEntidad, TEntidadID>
    {
        Task CrearAsync(TEntidad entidad);
        Task EditarAsync(TEntidad entidad);
        Task EliminarAsync(TEntidadID entidadId);
    }
}
