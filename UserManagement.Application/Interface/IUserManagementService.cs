using UserManagement.Domain.User;

namespace UserManagement.Application.Interface
{
    /// <summary>
    /// Interfaz para el servicio de gestión de usuarios.
    /// </summary>
    public interface IUserManagementService : IServiceBase<Users, Guid>
    {
    }
}
