namespace UserManagement.Application.Common.Exceptions
{
    /// <summary>
    /// Excepción personalizada para representar situaciones en las que la información proporcionada es inválida.
    /// </summary>
    public class InvalidInformationException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="InvalidInformationException"/> con un mensaje específico.
        /// </summary>
        /// <param name="message">Mensaje que describe la razón de la excepción.</param>
        public InvalidInformationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="InvalidInformationException"/> con un mensaje y una excepción interna.
        /// </summary>
        /// <param name="message">Mensaje que describe la razón de la excepción.</param>
        /// <param name="innerException">Excepción interna que causó la excepción actual.</param>
        public InvalidInformationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="InvalidInformationException"/> con el nombre y la clave de una entidad.
        /// </summary>
        /// <param name="name">Nombre de la entidad.</param>
        /// <param name="key">Clave de la entidad.</param>
        public InvalidInformationException(string name, object key)
            : base($"La entidad \"{name}\" ({key}) no se encontró.")
        {
        }
    }

}
