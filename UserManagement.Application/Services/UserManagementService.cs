using UserManagement.Application.Interface;
using UserManagement.Domain.Repository.Interface;
using UserManagement.Domain.User;

namespace UserManagement.Application.Services
{
    /// <summary>
    /// Implementación del servicio de gestión de usuarios.
    /// </summary>
    public class UserManagementService : IUserManagementService
    {
        private IUserRepository _userManaementService;
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UserManagementService"/>.
        /// </summary>
        /// <param name="userManaementService">Servicio para manejo de usuarios</param>
        public UserManagementService(IUserRepository userManaementService)
        {
            _userManaementService = userManaementService;
        }

        /// <inheritdoc />
        public async Task<Users> BuscarPorIdAsync(Guid entidadId)
        {
            return await _userManaementService.BuscarPorIdAsync(entidadId);
        }

        /// <inheritdoc />
        public async Task CrearAsync(Users entidad)
        {
            await _userManaementService.CrearAsync(entidad);
        }

        /// <inheritdoc />
        public async Task EditarAsync(Users entidad)
        {
            await _userManaementService.EditarAsync(entidad);
        }

        /// <inheritdoc />
        public async Task EliminarAsync(Guid entidadId)
        {
            await _userManaementService.EliminarAsync(entidadId);
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Users>> ListarAsync()
        {
            return await _userManaementService.ListarAsync();
        }
    }

}
