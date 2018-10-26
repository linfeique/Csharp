namespace exemplo_2510.ViewModels
{
    public class UsuarioViewModel : BaseViewModel  //Esse é o comando para criar herança
    {
        /// <summary>
        /// Email do usuário
        /// </summary>
        public string Email { get; set; }
    
        /// <summary>
        /// Senha do usuário.
        /// </summary>
        public string Senha { get; set; }
    
    }
}