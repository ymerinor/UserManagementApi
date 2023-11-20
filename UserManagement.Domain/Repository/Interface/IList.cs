namespace UserManagement.Domain.Repository.Interface
{
    /// <summary>
    /// Interfaz genérica para operaciones de listar y buscar entidades.
    /// </summary>
    /// <typeparam name="TEntidad">Tipo de entidad.</typeparam>
    /// <typeparam name="TEntidadID">Tipo de identificador de entidad.</typeparam>
    public interface IList<TEntidad, TEntidadID>
    {

        /// <summary>
        /// Obtiene una colección de todas las entidades de tipo <typeparamref name="TEntidad"/>.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve una colección de entidades.</returns>
        Task<IEnumerable<TEntidad>> ListarAsync();

        /// <summary>
        /// Busca una entidad por su identificador de tipo <typeparamref name="TEntidadID"/>.
        /// </summary>
        /// <param name="entidad">Identificador de la entidad que se va a buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve la entidad encontrada o null si no se encuentra.</returns>
        Task<TEntidad> BuscarPorIdAsync(TEntidadID entidad);
    }
}
