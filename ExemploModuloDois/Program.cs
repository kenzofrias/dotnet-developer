using System.Runtime.CompilerServices;
using ExemploModuloDois.Models;

Pessoa p1 = new Pessoa(nome:"Kenzo", sobrenome:"Friás");
Pessoa p2 = new Pessoa(nome:"Gabriel", sobrenome:"Oliveira");

Curso cursoDeIngles = new Curso(nome: "Ingles");

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();





// Pessoa p1 = new Pessoa();
// p1.Nome = "Gabriel";
// p1.Sobrenome = "Oliveira";
// p1.Idade = 20;
// p1.Apresentar();