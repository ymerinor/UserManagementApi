namespace UserManagement.Application.AuthenticationService.Interface
{
    public interface IAuthenicationService
    {
        /// <summary>
        /// Metodo para realizar el proceso de login de la API
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string username, string password);

        /// <summary>
        /// Obtiene el metodo de sesion de la aplicacion
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        string GetToken(string username);
    }
}
