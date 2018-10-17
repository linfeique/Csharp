using System;

namespace Senai.Sistema.Viagem.classes
{
    public class Passagem
    {
        /// <summary>
        ///     Número da passagem
        /// </summary>

        public int Numero { get; set; }

        /// <summary>
        ///     Nome do passageiro
        /// </summary>
    
        public string NomePassageiro { get; set; }

        /// <sumary>
        ///     A data do voo
        /// </summary>

        public DateTime Data { get; set; }
    }
}