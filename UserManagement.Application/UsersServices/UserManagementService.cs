using UserManagement.Application.Common.Exceptions;
using UserManagement.Application.Common.Models;
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
        public async Task<Users> CrearAsync(Users users)
        {
            if (string.IsNullOrEmpty(users.Email) || string.IsNullOrEmpty(users.Name))
                throw new InvalidInformationException("el name o email  no puede ser vacios o null");
            return await _userRepository.CrearAsync(users);
        }

        /// <inheritdoc />
        public async Task EditarAsync(Users users)
        {
            await _userRepository.EditarAsync(users);
        }

        /// <inheritdoc />
        public async Task EliminarAsync(Guid idUser)
        {
            await _userRepository.EliminarAsync(idUser);
        }
        /// <inheritdoc />
        public async Task<PagedResult<Users>> ListadoPaginado(int page, int pageSize)
        {
            var informacion = await _userRepository.ListarAsync();
            var resultadoPaginado = informacion.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new PagedResult<Users>
            {
                Data = resultadoPaginado,
                Page = page,
                PageSize = pageSize,
                TotalItems = informacion.Count()
            };
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Users>> ListarAsync()
        {
            return await _userRepository.ListarAsync();
        }
    }

}
