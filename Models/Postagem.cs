using System;
using System.ComponentModel.DataAnnotations;

namespace RedeSocial.Models
{
    public class Postagem
    {
        public int idPostagem { get; set; }
        public string Nick { get; set; }
        public string Texto { get; set; }
        public string Foto { get; set; }

        [DisplayFormat(DataFormatString = "{0:HH:mm ddd, d MMM")]
        public DateTime DataHora { get; set; }
    }
}