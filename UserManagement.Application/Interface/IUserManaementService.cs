using UserManagement.Domain.Entity;

namespace UserManagement.Application.Interface
{
    /// <summary>
    /// Interfaz para el servicio de gestión de usuarios.
    /// </summary>
    public interface IUserManaementService : IServiceBase<User, Guid>
    {
    }
}
