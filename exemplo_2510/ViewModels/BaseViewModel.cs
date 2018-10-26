using System;

namespace exemplo_2510.ViewModels
{
    /// <summary>
    /// Classe base que será herdada pelas outras classes.
    /// A classe BaseViewModel é definida como abstrata para não ser instanciada. Ela só serve para evitar que atributos comuns a mais de duas classes sejam escritos várias vezes. 
    /// </summary>
    
    public abstract class BaseViewModel
    {
        public int Id { get; set; }  //Id do Objeto

        public string Nome { get; set; }  //Nome do Objeto
        
        public DateTime DataCriacao { get; set; } //Data de criação do Objeto
    }
}