// See https://aka.ms/new-console-template for more information
public class Autor
{
    public Autor(string nome, DateTime dataNascimento, string nacionalidade)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Nacionalidade = nacionalidade;
    }

    public string Nome { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public string Nacionalidade { get; private set; }
}