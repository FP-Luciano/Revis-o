using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão.Model
{
    public class Biblioteca
    {
        private List<Livro> livros;
        private List<Leitor> leitores;

        public Biblioteca()
        {
            livros = new List<Livro>();
            leitores = new List<Leitor>();
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void AdicionarLeitor(Leitor leitor)
        {
            leitores.Add(leitor);
        }

        public void EmprestarLivro(Leitor leitor, Livro livro)
        {
            if (!livro.Disponivel)
            {
                Console.WriteLine($"O livro \"{livro.Titulo}\" ({livro.Autor}) não está disponível.");
                return;
            }

            livro.Disponivel = false;
            livro.LeitorQueEmprestou = leitor;
            Console.WriteLine($"{leitor.Nome} {leitor.Sobrenome} pegou o livro \"{livro.Titulo}\" do autor \"{livro.Autor}\" emprestado.");
        }

        public void DevolverLivro(Leitor leitor, Livro livro)
        {
            if (livro.Disponivel || livro.LeitorQueEmprestou != leitor)
            {
                Console.WriteLine($"{leitor.Nome} {leitor.Sobrenome} não pegou o livro \"{livro.Titulo}\" ({livro.Autor}) emprestado.");
                return;
            }

            livro.Disponivel = true;
            Console.WriteLine($"{leitor.Nome} {leitor.Sobrenome} devolveu o livro \"{livro.Titulo}\" ({livro.Autor}).");
        }

        public void ListarLivrosDisponiveis()
        {
            Console.WriteLine("Livros Disponíveis:");
            foreach (var livro in livros)
            {
                if (livro.Disponivel)
                    Console.WriteLine($"- \"{livro.Titulo}\" ({livro.Autor})");
            }
        }

        public void ListarLivrosEmprestados()
        {
            Console.WriteLine("Livros Emprestados:");
            foreach (var livro in livros)
            {
                if (!livro.Disponivel)
                {
                    foreach (var leitor in leitores)
                    {
                        if (leitor == livro.LeitorQueEmprestou)
                        {
                            Console.WriteLine($"- \"{livro.Titulo}\" ({livro.Autor}) emprestado para {leitor.Nome} {leitor.Sobrenome}.");
                            break;
                        }
                    }
                }
            }
        }
    }
}