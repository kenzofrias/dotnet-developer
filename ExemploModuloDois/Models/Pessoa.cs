using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploModuloDois.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Digite seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            Sobrenome = Console.ReadLine();
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        //private - acessível apenas dentro das chaves em que ele estiver presente
        //public - acessível a qualquer um
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome

        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                    //lança um argumento como excessão caso aconteça um "problema", mas encerra o programa caso válido
                }
                _nome = value;
            }
        }
        public string Sobrenome
        {
            get => _sobrenome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio!");
                }
                _sobrenome = value;
            } 
        }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero!");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}; Idade: {Idade}.");
        }
    }
}