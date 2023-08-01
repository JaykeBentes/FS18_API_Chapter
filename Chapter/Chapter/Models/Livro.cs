namespace Chapter.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int QuantidadePaginas { get;}

        public bool Disponivel { get; set; }
    }
}
