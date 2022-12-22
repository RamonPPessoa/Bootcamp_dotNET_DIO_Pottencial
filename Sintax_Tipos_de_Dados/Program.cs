using Sintax_Tipos_de_Dados.Models;
 

string apresentacao = "Bootcamp .NET";

int quantidade = 1;
double altura = 1.70;
decimal preco = 1.80M;

bool condicao = true;


Console.WriteLine(apresentacao);
System.Console.WriteLine("Valor da quantidade: " + quantidade);
System.Console.WriteLine("Valor da altura: " + altura.ToString("0.00"));
System.Console.WriteLine("Valor do preço: " + preco);
System.Console.WriteLine("A condição é: " + condicao);



// Pessoa pessoa01 = new Pessoa();

// pessoa01.Nome = "Alex";
// pessoa01.Idade = 28;
// pessoa01.Apresentar();