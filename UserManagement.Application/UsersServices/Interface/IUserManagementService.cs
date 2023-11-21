using UserManagement.Application.Common.Models;
using UserManagement.Domain.Repository.Interface;
using UserManagement.Domain.User;

namespace UserManagement.Application.UsersServices.Interface
{
    /// <summary>
    /// Interfaz para el servicio de gestión de usuarios.
    /// </summary>
    public interface IUserManagementService : IUserRepository
    {
        // <summary>
        /// Obtiene un listado paginado de usuarios.
        /// </summary>
        /// <param name="page">Número de página.</param>
        /// <param name="pageSize">Tamaño de la página (cantidad de elementos por página).</param>
        /// <returns>Un objeto <see cref="Task"/> que representa la operación asincrónica, que devuelve un <see cref="PagedResult{T}"/> de tipo <see cref="Users"/>.</returns>
        /// <remarks>
        /// El método devuelve un listado paginado de usuarios basado en los parámetros de paginación especificados.
        /// </remarks>
        Task<PagedResult<Users>> ListadoPaginado(int page, int pageSize);
    }
}
