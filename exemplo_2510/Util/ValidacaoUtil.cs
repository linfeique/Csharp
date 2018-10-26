namespace exemplo_2510.Util
{
    /// <summary>
    /// Classe responsável pelas validações 
    /// </summary>
    
    public static class ValidacaoUtil
    {
        /// <summary>
        /// Método responsável por validar o e-mail
        /// </summary>
        /// <param name="email">Email a ser validado</param>
        /// <returns>Retorna true para email válido e false para inválido</returns>
        public static bool ValidarEmail(string email)
        {
            if(email.Contains("@") && email.Contains("."))
            {
                return true;
            }
                
            return false;
        }

        /// <summary>
        /// Valida a senha informada
        /// </summary>
        /// <param name="senha">Senha passada</param>
        /// <returns>Retorna true caso a senha esteja ok e false se estiver errada</returns>
        public static bool ValidarSenha(string senha)
        {
            if(senha.Length >=6) //Verifica se a senha tem pelo menos 6 caracteres
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Valida a categoria informada.
        /// </summary>
        /// <param name="categoria">Categoria deve ser pizza ou bebida</param>
        /// <returns>Retorna true caso a categoria seja Pizza/Bebida ou false caso não for.</returns>
        public static bool ValidaCategoria(string categoria)
        {
            //ToLower transforma em minúsculo o que o usuário digitar.
            if(categoria.ToLower() == "pizza" || categoria.ToLower() == "bebida")
            {
                return true;
            }

            return false;
        }
    }
}