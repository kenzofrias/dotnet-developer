using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace ExemploModuloDois.Models
{
    public class Curso
    {
        public Curso(string nome)
        {
            Nome = nome;
            Alunos = new List<Pessoa>();
        }
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } //cria uma lista para receber Alunos de dentro da classe Pessoa

        public void AdicionarAluno(Pessoa aluno) //função/método para adicionar novo aluno sem retornar nada
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidaDeAlunosMatriculados() //função/método para contar quantos alunos existem no curso/lista
        {
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            
            Console.WriteLine($"Alunos matrículados no curso de {Nome}:");
            for(int count = 0; count < Alunos.Count; count++)
            {
                Console.WriteLine($"{count + 1} - {Alunos[count].NomeCompleto}");
            }
        }
    }
}