namespace UserManagement.Domain.Repository.Interface
{
    public interface IRepositoryBase<TEntidad, TEntidadID> : IList<TEntidad, TEntidadID>
    {
        void Crear(TEntidad entidad);
        void Editar(TEntidad entidad);
        void Eliminar(TEntidadID entidadId);
    }
}
