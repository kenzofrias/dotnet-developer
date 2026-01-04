using System.Runtime.Serialization;
using aulas.classes.aula001;

Pessoa p1 = new Pessoa();

p1.Nome = "Kenzo";
p1.Idade = 19;

Console.WriteLine($"Nome: {p1.Nome}");
Console.WriteLine($"Idade: {p1.Idade}");
p1.apresentar();