using System.ComponentModel.DataAnnotations;

namespace UserManagement.Domain.Entity
{
    /// <summary>
    /// Representa a un usuario en el sistema.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Obtiene o establece el identificador único del usuario.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del usuario.
        /// </summary>
        [Required]
        public string Nombre { get; set; } = null!;

        /// <summary>
        /// Obtiene o establece la dirección de correo electrónico del usuario.
        /// </summary>
        [Required]
        public string Correo { get; set; } = null!;

        /// <summary>
        /// Obtiene o establece la edad del usuario.
        /// </summary>
        [Required]
        public int Edad { get; set; }

        /// <summary>
        /// Obtiene o establece la nacionalidad del usuario.
        /// </summary>
        public string Nacionalidad { get; set; } = string.Empty;
    }
}
