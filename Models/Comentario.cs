namespace RedeSocial.Models
{
    public class Comentario
    {
        public int idComentario { get; set; }
        public int idPostagem { get; set; }
        public string Nick { get; set; }
        public string Texto { get; set; }
    }
}