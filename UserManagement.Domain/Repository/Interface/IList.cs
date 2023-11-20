namespace UserManagement.Domain.Repository.Interface
{
    public interface IList<TEntidad, TEntidadID>
    {
        List<TEntidad> Listar();
        TEntidad BuscarPorId(TEntidadID entidad);
    }
}
