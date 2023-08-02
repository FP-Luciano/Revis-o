using Revisão.Model;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Livro livro1 = new Livro("The Last Wish", "Andrzej Sapkowski");
        Livro livro2 = new Livro("Turma da Monica", "Mauricio de Sousa");
        Livro livro3 = new Livro("The Voyage of the Dawn Treader", "Clive Staples Lewis");

        Leitor leitor1 = new Leitor("Richard", "Francis");
        Leitor leitor2 = new Leitor("Gabriel", "Souza");
        Leitor leitor3 = new Leitor("Rosenclever", "Lopes");

        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);

        biblioteca.AdicionarLeitor(leitor1);
        biblioteca.AdicionarLeitor(leitor2);
        biblioteca.AdicionarLeitor(leitor3);

        biblioteca.EmprestarLivro(leitor1, livro1);
        biblioteca.EmprestarLivro(leitor1, livro2);
        biblioteca.EmprestarLivro(leitor2, livro2);
        biblioteca.EmprestarLivro(leitor3, livro3);

        biblioteca.DevolverLivro(leitor1, livro2);
        biblioteca.DevolverLivro(leitor2, livro2);
        biblioteca.DevolverLivro(leitor3, livro3);

        biblioteca.ListarLivrosDisponiveis();
        biblioteca.ListarLivrosEmprestados();
    }
}