using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace common.aulas.classes.aula001 //caminho lógico da classe
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>

    public class Pessoa //classes sempre começar com letra maiúscula
    {
        //cobrar apenas informações que serão, de fato, usadas
        public string? Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Faz a pessoa se apresentar com nome e idade
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}