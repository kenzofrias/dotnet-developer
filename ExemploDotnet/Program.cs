using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using common.aulas.classes.aula001;
using common.aulas.Operadores.Aritmeticos;

List<string> listaString = new List<string>();

listaString.Add("SP"); //adiciona um elemento
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");


Pessoa p = new Pessoa();
p.Apresentar();

Calculador c = new Calculador();
c.Somar(5, 2);
c.Subtrair(3, 4);


// Arrays e Listas
// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


// Console.WriteLine("Por FOR:");
// for(int cont = 0; cont < listaString.Count; cont++)
// {
//     Console.WriteLine($"Posução Nº {cont} - {listaString[cont]}");
// }

// Console.WriteLine("Por FOEACH:");
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Valor --> {item}");
// }


// int[] arrayInteiros = new int[4]; 

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo usando FOR:");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }


// Console.WriteLine("Percorrendo usando FOREACH:");
// int posicao = 0;
// foreach(int element in arrayInteiros)
// {
//     Console.WriteLine($"Posição 'foreach' Nº {posicao} - {element}");
//     posicao++;
// }


// Estrutura obrigatória do dotnet 5 para baixo
// namespace ExemploDotnet.NET5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello word in Dotnet 5");
//         }
//     }
// }



// Pessoa pessoa1 =  new Pessoa();
// pessoa1.Nome = "Gabriel";
// pessoa1.Idade = 29;
// pessoa1.Apresentar();



// LAÇOS DE REPETIÇÃO
// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
        
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
        
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
        
//         case "4":
//             Console.WriteLine("Encerrado!");
//             exibirMenu = false;
//             // Environment.Exit(0);
//             break;
        
//         default:
//             Console.WriteLine("Opção inválida.");
//             break;
//     }
// }

// Console.WriteLine("Programa encerrado!");



// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número para somar (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero != 0);

// Console.WriteLine(soma);


// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if(contador > 5)
//     {
//         break;
//     }
// }
// Console.WriteLine("FIM DA PAPO!");


// int numero  = 5;

// for(int contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }



// OPERADORES ARITMETICOS
// Calculador calc = new Calculador();

// calc.Raiz(9);


// int numero = 10;

// Console.WriteLine(numero);
// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numero++;
// Console.WriteLine(++numero);

// int numeroDois = 10;

// Console.WriteLine(numeroDois);
// Console.WriteLine("Incrementando o 10");
// // numeroDois = numeroDois - 1;
// numeroDois--;
// Console.WriteLine(--numeroDois);



// calc.Somar(10,20);
// calc.Subtrair(30,10);
// calc.Multiplicar(10,5);
// calc.Dividir(100,10);
// calc.Potencia(2,2);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);



// OPERADORES LÓGICOS
// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar amanhã.");
// }


// bool possuiPresencaMinima = false;
// bool possuiMedia = false;

// if (possuiPresencaMinima && possuiMedia)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }


// Console.WriteLine("Você é maior de idade (s/n)?");
// string idade = Console.ReadLine();

// Console.WriteLine("Você possui autorização dos pais (s/n)?");
// string autorizacao = Console.ReadLine();


// if(idade == "s" || autorizacao == "s")
// {
//     Console.WriteLine("Você pode entrar!");
// }
// else
// {
//    Console.WriteLine("Você não pode entrar!");
// }


// Console.WriteLine("Você é maior de idade (s/n)?");
// string idade = Console.ReadLine();

// if(idade == "s" || )
// {
//     Console.WriteLine("Você pode entrar!");
// }
// else
// {
//     Console.WriteLine("Você possui autorização dos pais (s/n)?");
//     string autorizacao = Console.ReadLine();

//     if(autorizacao == "s")
//     {
//         Console.WriteLine("Você pode entrar!");
//     }
//     else
//     {
//         Console.WriteLine("Você não pode entrar!");
//     }
// }


// Console.WriteLine("Você é maior de idade (s/n)?");
// string idade = Console.ReadLine();

// Console.WriteLine("Você possui autorização dos pais (s/n)?");
// string autorizacao = Console.ReadLine();

// if(idade == "s")
// {
//     Console.WriteLine("Você pode entrar!");
// }
// else if(idade == "n" && autorizacao == "s")
// {
//     Console.WriteLine("Você pode entrar!");
// }
// else
// {
//     Console.WriteLine("Você não pode entrar!");
// }


// Console.WriteLine("Digite uma letra.");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal!");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal!");
//         break;
// }


// if(letra == "a" || 
//     letra == "e" || 
//     letra == "i" || 
//     letra == "o" || 
//     letra == "u")
// {
//     Console.WriteLine("Vogal!");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal!");
// }


// if(letra == "a")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal!");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal!");
// }


// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade para compra: {quantidadeCompra}");
// Console.WriteLine($"\nÉ possível realizar a compra? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("\nVenda inválida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("\nVenda realizada!");
// }
// else
// {
//     Console.WriteLine("\nDesculpe, não temos a quantidade desejada em estoque.");
// }



// OPERADORES INÍCIO
// string numero = "15-";
// int erro = 0;

// //se sucesso, substitui o 'erro' pelo numero convertido
// //se sem sucesso, manda o valor original colocado para erro
// Console.WriteLine(int.TryParse(numero, out erro));
// Console.WriteLine(erro);
// Console.WriteLine("Sucesso!");


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