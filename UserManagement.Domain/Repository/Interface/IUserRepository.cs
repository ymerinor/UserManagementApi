using UserManagement.Domain.User;

namespace UserManagement.Domain.Repository.Interface
{
    public interface IUserRepository
    {
        Task CrearAsync(Users entidad);
        Task EditarAsync(Users entidad);
        Task EliminarAsync(Guid entidadId);
        /// <summary>
        /// Obtiene una colección de todas las entidades de tipo <typeparamref name="TEntidad"/>.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve una colección de entidades.</returns>
        Task<IEnumerable<Users>> ListarAsync();

        /// <summary>
        /// Busca una entidad por su identificador de tipo <typeparamref name="TEntidadID"/>.
        /// </summary>
        /// <param name="entidad">Identificador de la entidad que se va a buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve la entidad encontrada o null si no se encuentra.</returns>
        Task<Users> BuscarPorIdAsync(Guid entidad);
    }
}
