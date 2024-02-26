IBiblioteca biblioteca = new Biblioteca();

//populando biblioteca
for (int i = 0; i < 10; i++)
{
    biblioteca.AdicionarLivro(new Livro(titulo: $"Meu Livro Teste {i}",
                                        autor: new Autor("Rubens", new DateTime(1994, 7, 12), "Brasileiro"),
                                        anoPublicacao: new Random().Next(1950, 2024),
                                        numeroPaginas: new Random().Next(25, 800)));
}

ILivro livroAleatorio = biblioteca.RetornarLivroEspecifico(new Random().Next(0, 10));

Console.WriteLine(livroAleatorio.Detalhes());

var todosLivros = biblioteca.RetornarTodosLivros();

livroAleatorio.AjustarDiponibilidade();

var todosLivrosDisponiveis = biblioteca.RetornarLivrosDisponiveis();

Console.WriteLine();






