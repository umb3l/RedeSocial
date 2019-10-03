using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedeSocial.Models
{
    public class Notificacao
    {
        public int idNotificacao { get; set; }
        public string Nick { get; set; }
        public string Texto { get; set; }
    }
}