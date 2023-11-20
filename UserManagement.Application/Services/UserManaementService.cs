using UserManagement.Application.Interface;
using UserManagement.Domain.Entity;

namespace UserManagement.Application.Services
{
    /// <summary>
    /// Implementación del servicio de gestión de usuarios.
    /// </summary>
    public class UserManagementService : IUserManaementService
    {
        private readonly IUserManaementService _userManaementService;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UserManagementService"/>.
        /// </summary>
        /// <param name="userManaementService">Servicio para manejo de usuarios</param>
        public UserManagementService(IUserManaementService userManaementService)
        {
            _userManaementService = userManaementService;
        }

        /// <inheritdoc />
        public async Task<User> BuscarPorIdAsync(Guid entidadId)
        {
            return await _userManaementService.BuscarPorIdAsync(entidadId);
        }

        /// <inheritdoc />
        public async Task CrearAsync(User entidad)
        {
            await _userManaementService.CrearAsync(entidad);
        }

        /// <inheritdoc />
        public async Task EditarAsync(User entidad)
        {
            await _userManaementService.EditarAsync(entidad);
        }

        /// <inheritdoc />
        public async Task EliminarAsync(Guid entidadId)
        {
            await _userManaementService.EliminarAsync(entidadId);
        }

        /// <inheritdoc />
        public async Task<IEnumerable<User>> ListarAsync()
        {
            return await _userManaementService.ListarAsync();
        }
    }

}
