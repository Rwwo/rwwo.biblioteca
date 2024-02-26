public class Livro : ILivro
{
    public Livro(string titulo, Autor autor, int anoPublicacao, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        NumeroPaginas = numeroPaginas;
        Disponivel = true;
    }

    public string Titulo { get; private set; }
    public Autor Autor { get; private set; }
    public int AnoPublicacao { get; private set; }
    public int NumeroPaginas { get; private set; }
    public bool Disponivel { get; private set; } 

    public void AjustarDiponibilidade() => Disponivel = !Disponivel;

    public string Detalhes()
    {
        return $"Título: {Titulo}, Autor: {Autor.Nome}, Ano Publicação {AnoPublicacao}, Quantidade de Páginas {NumeroPaginas}";
    }

}