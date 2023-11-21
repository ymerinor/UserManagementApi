namespace UserManagement.Application.Common.Exceptions
{
    /// <summary>
    /// Excepción que representa un intento de acceder a un recurso para el cual el acceso está prohibido.
    /// </summary>
    public class ForbiddenAccessException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ForbiddenAccessException"/>.
        /// </summary>
        public ForbiddenAccessException() : base() { }
    }

}
