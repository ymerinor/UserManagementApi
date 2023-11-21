using System.ComponentModel.DataAnnotations;

namespace UserManagement.Domain.User
{
    /// <summary>
    /// Representa a un usuario en el sistema.
    /// </summary>
    public class Users
    {
        /// <summary>
        /// Obtiene o establece el identificador único del usuario.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del usuario.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Obtiene o establece la dirección de correo electrónico del usuario.
        /// </summary>
        [Required]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Obtiene o establece la edad del usuario.
        /// </summary>
        [Required]
        public int Age { get; set; }

        /// <summary>
        /// Obtiene o establece la nacionalidad del usuario.
        /// </summary>
        public string Nationality { get; set; } = string.Empty;
    }
}
