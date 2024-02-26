// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;

public class Biblioteca : IBiblioteca
{
    private List<Livro> LivrosDisp = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        LivrosDisp.Add(livro);
    }
    public ReadOnlyCollection<Livro> RetornarLivrosDisponiveis()
    {
        return LivrosDisp.Where(t => t.Disponivel==true).ToList().AsReadOnly();
    }

    public ReadOnlyCollection<Livro> RetornarTodosLivros()
    {
        return LivrosDisp.AsReadOnly();
    }

    public Livro RetornarLivroEspecifico(int indice)
    {
        if (indice < this.LivrosDisp.Count)
            return this.LivrosDisp[indice];
        else
            throw new IndexOutOfRangeException("O índice está fora dos limites.");

    }

}
