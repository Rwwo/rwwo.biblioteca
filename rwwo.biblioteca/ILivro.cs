public interface ILivro
{
    int AnoPublicacao { get; }
    Autor Autor { get; }
    bool Disponivel { get; }
    int NumeroPaginas { get; }
    string Titulo { get; }

    void AjustarDiponibilidade();
    string Detalhes();
}