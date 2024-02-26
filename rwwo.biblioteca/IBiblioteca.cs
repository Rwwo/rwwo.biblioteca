// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;

public interface IBiblioteca
{
    void AdicionarLivro(Livro livro);
    ReadOnlyCollection<Livro> RetornarLivrosDisponiveis();
    ReadOnlyCollection<Livro> RetornarTodosLivros();

    Livro RetornarLivroEspecifico(int indice);
}