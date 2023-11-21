using UserManagement.Domain.User;

namespace UserManagement.Domain.Repository.Interface
{
    /// <summary>
    /// Interface de definicion de metodos para IUserRepository
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Crea un nuevo usuario de forma asincrónica.
        /// </summary>
        /// <param name="users">El objeto <see cref="Users"/> que representa al nuevo usuario.</param>
        /// <returns>Un objeto <see cref="Task"/> que representa la operación asincrónica.</returns>
        /// <remarks>
        /// Este método crea un nuevo usuario utilizando la información proporcionada en el objeto <paramref name="users"/>.
        /// </remarks>
        Task<Users> CrearAsync(Users users);
        /// <summary>
        /// Edita un usuario existente de forma asincrónica.
        /// </summary>
        /// <param name="users">El objeto <see cref="Users"/> que representa al usuario a editar.</param>
        /// <returns>Un objeto <see cref="Task"/> que representa la operación asincrónica.</returns>
        /// <remarks>
        /// Este método actualiza la información de un usuario existente utilizando los datos proporcionados en el objeto <paramref name="users"/>.
        /// </remarks>
        Task EditarAsync(Users users);

        /// <summary>
        /// Elimina un usuario de forma asincrónica por su identificador único.
        /// </summary>
        /// <param name="idUser">El identificador único del usuario a eliminar.</param>
        /// <returns>Un objeto <see cref="Task"/> que representa la operación asincrónica.</returns>
        /// <remarks>
        /// Este método elimina un usuario identificado por su <paramref name="idUser"/>.
        /// </remarks>
        Task EliminarAsync(Guid idUser);
        /// <summary>
        /// Obtiene una colección de todas las entidades de tipo <typeparamref name="idUser"/>.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve una colección de entidades.</returns>
        Task<IEnumerable<Users>> ListarAsync();

        /// <summary>
        /// Busca una entidad por su identificador de tipo <typeparamref name="TEntidadID"/>.
        /// </summary>
        /// <param name="idUser">Identificador de la entidad que se va a buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve la entidad encontrada o null si no se encuentra.</returns>
        Task<Users> BuscarPorIdAsync(Guid entidad);
    }
}
