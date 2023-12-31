﻿namespace UserManagement.Application.Common.Exceptions
{
    /// <summary>
    /// Excepción que representa la falta de un recurso buscado.
    /// </summary>
    public class NotFoundException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="NotFoundException"/> con un mensaje específico.
        /// </summary>
        /// <param name="message">Mensaje que describe la razón de la excepción.</param>
        public NotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="NotFoundException"/> con un mensaje y una excepción interna.
        /// </summary>
        /// <param name="message">Mensaje que describe la razón de la excepción.</param>
        /// <param name="innerException">Excepción interna que causó la excepción actual.</param>
        public NotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="NotFoundException"/> con el nombre y la clave de una entidad.
        /// </summary>
        /// <param name="name">Nombre de la entidad.</param>
        /// <param name="key">Clave de la entidad.</param>
        public NotFoundException(string name, object key)
            : base($"La entidad \"{name}\" ({key}) no se encontró.")
        {
        }
    }

}
