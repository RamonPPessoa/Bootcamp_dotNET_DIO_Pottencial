using Propriedades_Metodos_Construtores.Models;
using System;
using System.Globalization;

// Formatação de acordo com a cultura

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// Formatando valores monetários


decimal valorMonetario = 1590.78M;

System.Console.WriteLine($"{valorMonetario:C}");



// Pessoa pessoa1 = new Pessoa("Joao","Buta");
 
// Pessoa pessoa2 = new Pessoa(nome:"Joaquim", sobrenome: "Nunes");






// Curso cursoIdiomas = new Curso();
// cursoIdiomas.Nome = "Inglês";
// cursoIdiomas.Alunos = new List<Pessoa>();


// cursoIdiomas.AdicionarAluno(pessoa1);
// cursoIdiomas.AdicionarAluno(pessoa2);
// cursoIdiomas.ListarAlunos();


// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "João";
// pessoa1.Sobrenome = "Silva"; 
// pessoa1.Idade = 25;
// pessoa1.Apresentar();
