using System;

namespace RedeSocial.Models
{
    public class Usuario
    {
        public string Nick { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Bio { get; set; }
        public Boolean Privacidade { get; set; }
    }
}