using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using aulas.classes.aula001;


string numero = "15-";
int erro = 0;

//se sucesso, substitui o 'erro' pelo numero convertido
//se sem sucesso, manda o valor original colocado para erro
Console.WriteLine(int.TryParse(numero, out erro));
Console.WriteLine(erro);
Console.WriteLine("Sucesso!");


// double a = 4/(2+2);
// Console.WriteLine(a);


//conversão de menor pra maior é automatico
//conversão de maior pra menor é manual
// int a = 5;
// long b = a;
// Console.WriteLine(b);


// int a = int.MinValue;
// long b = a;

// Console.WriteLine(b);

// int a = 5;
// string numero = a.ToString();
// Console.WriteLine(numero);


//Cast - Casting
// int a = Convert.ToInt32("5");
// Console.WriteLine(a);

// int b = int.Parse("10");
// Console.WriteLine(b);


// //sinal de igual é o operador de atribuição
// int a = 20;
// int b = 30;

// int c = a + b;
// Console.WriteLine($"A soma dos valores de a e b é {c}");

// c += 5;
// Console.WriteLine($"A soma anterior + 5 é {c}");

// c -= 10;
// Console.WriteLine($"A soma anterior - 10 é {c}");

// c *= 2;

// Console.WriteLine($"A subtração anterior x2 é {c}");

// c /= 10;

// Console.WriteLine($"A multiplicação anterior /10 é {c}");



// TIPOS DE DADOS
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Olá, seja bem-vindo";
// double altura = 1.80d;
// decimal preco = 1.80m;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);


// int quantidade = 1;
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);

// quantidade = 20;
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);


// CLASSES
// Pessoa p1 = new Pessoa();

// p1.Nome = "Kenzo";
// p1.Idade = 19;
// p1.Apresentar();