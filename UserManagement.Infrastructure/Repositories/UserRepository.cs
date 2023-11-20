using Microsoft.EntityFrameworkCore;
using UserManagement.Domain.Entity;
using UserManagement.Domain.Repository.Interface;

namespace UserManagement.Infrastructure.Repositories
{
    /// <summary>
    /// Repositorio para realizar operaciones CRUD en la entidad User.
    /// </summary>
    public class UserRepository : IRepositoryBase<User, Guid>
    {
        private readonly UserManagementDbContext _context;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UserRepository"/>.
        /// </summary>
        /// <param name="context">Contexto de la base de datos.</param>
        public UserRepository(UserManagementDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Busca un usuario por su identificador.
        /// </summary>
        /// <param name="entidad">Identificador del usuario a buscar.</param>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve el usuario encontrado o null si no se encuentra.</returns>
        public async Task<User> BuscarPorIdAsync(Guid entidad)
        {
            var resultadoConsulta = await _context.Usuarios.Where(t => t.Id == entidad).FirstOrDefaultAsync();
            return resultadoConsulta;
        }

        /// <summary>
        /// Crea un nuevo usuario.
        /// </summary>
        /// <param name="entidad">Usuario a crear.</param>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public async Task CrearAsync(User entidad)
        {
            entidad.Id = Guid.NewGuid();
            _context.Usuarios.Add(entidad);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Edita un usuario existente.
        /// </summary>
        /// <param name="entidad">Usuario con las actualizaciones.</param>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public async Task EditarAsync(User entidad)
        {
            var usuarioSeleccionado = await _context.Usuarios.Where(t => t.Id == entidad.Id).FirstOrDefaultAsync();
            if (usuarioSeleccionado != null)
            {
                usuarioSeleccionado.Nombre = entidad.Nombre;
                usuarioSeleccionado.Correo = entidad.Correo;
                usuarioSeleccionado.Edad = entidad.Edad;
                _context.Entry(usuarioSeleccionado).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Elimina un usuario por su identificador.
        /// </summary>
        /// <param name="entidadId">Identificador del usuario a eliminar.</param>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public async Task EliminarAsync(Guid entidadId)
        {
            var usuarioEliminar = await _context.Usuarios.Where(t => t.Id == entidadId).FirstOrDefaultAsync();
            if (usuarioEliminar != null)
            {
                _context.Usuarios.Remove(usuarioEliminar);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Obtiene una lista de todos los usuarios.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica. La tarea devuelve una colección de usuarios.</returns>
        public async Task<IEnumerable<User>> ListarAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}
