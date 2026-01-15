using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace common.aulas.Operadores.Aritmeticos
{
    public class Calculador
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="x">Primeiro número inteiro para somar</param>
        /// <param name="y">Segundo número iinteiro para somar</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        /// <summary>
        /// Realiza uma subtração de dois numeros
        /// </summary>
        /// <param name="x">Primeiro numero inteiro para subtrair</param>
        /// <param name="y">Segundo numero inteiro para subtrair</param>
        /// <returns>Retorna a subtração de x e y</returns>
        public int Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            if(y == 0)
            {
                Console.WriteLine("Impossível realizar a operação.");
            }
            else
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = (angulo * Math.PI/180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = (angulo * Math.PI/180);
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = (angulo * Math.PI/180);
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void Raiz(double x)
        {
            double raiz =  Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }  
}