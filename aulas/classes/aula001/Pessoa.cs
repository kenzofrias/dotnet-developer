using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulas.classes.aula001 //caminho lógico da classe
{
    public class Pessoa //classes sempre começar com letra maiúscula
    {
        //cobrar apenas informações que serão, de fato, usadas
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}