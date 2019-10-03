using System;

namespace RedeSocial.Models
{
    public class Amizade
    {
        public string NickSeguindo { get; set; }
        public string NickSeguidor { get; set; }
        public Boolean Bloqueado { get; set; }
        public Boolean Privacidade { get; set; }

    }
}