using Propriedades_Metodos_Construtores.Models;


Pessoa pessoa1 = new Pessoa("Joao","Buta");
 
Pessoa pessoa2 = new Pessoa(nome:"Joaquim", sobrenome: "Nunes");






Curso cursoIdiomas = new Curso();
cursoIdiomas.Nome = "Inglês";
cursoIdiomas.Alunos = new List<Pessoa>();


cursoIdiomas.AdicionarAluno(pessoa1);
cursoIdiomas.AdicionarAluno(pessoa2);
cursoIdiomas.ListarAlunos();


// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "João";
// pessoa1.Sobrenome = "Silva"; 
// pessoa1.Idade = 25;
// pessoa1.Apresentar();
