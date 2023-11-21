using UserManagement.Application.UsersServices.Interface;
using UserManagement.Domain.Repository.Interface;
using UserManagement.Domain.User;

namespace UUserManagement.Application.UsersServices
{
    /// <summary>
    /// Implementación del servicio de gestión de usuarios.
    /// </summary>
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserRepository _userRepository;
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UserManagementService"/>.
        /// </summary>
        /// <param name="userRepository">Servicio para manejo de usuarios</param>
        public UserManagementService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <inheritdoc />
        public async Task<Users> BuscarPorIdAsync(Guid entidadId)
        {
            return await _userRepository.BuscarPorIdAsync(entidadId);
        }

        /// <inheritdoc />
        public async Task CrearAsync(Users entidad)
        {
            await _userRepository.CrearAsync(entidad);
        }

        /// <inheritdoc />
        public async Task EditarAsync(Users entidad)
        {
            await _userRepository.EditarAsync(entidad);
        }

        /// <inheritdoc />
        public async Task EliminarAsync(Guid entidadId)
        {
            await _userRepository.EliminarAsync(entidadId);
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Users>> ListarAsync()
        {
            return await _userRepository.ListarAsync();
        }
    }

}
