using Propriedades_Metodos_Construtores.Models;
using System;
using System.Globalization;


// Leitura de arquivo

//Exceção genérica e especifica

try
{
    string[]linhas = File.ReadAllLines("Arquivos/wow/arquivoLeitura.txt");


foreach (var item in linhas)
{
    System.Console.WriteLine(item);
}
}
catch (FileNotFoundException ex)
{
    System.Console.WriteLine($"Ocorreu uma execução generica.{ex.Message}");
    
}
catch (DirectoryNotFoundException ex)
{
    System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo.Caminho da pasta não encontrado.{ex.Message}");
    
}
catch (Exception ex)
{
    System.Console.WriteLine($"Ocorreu uma execução generica.{ex.Message}");
    
}
finally
{
    System.Console.WriteLine("Chegou até aqui");
}














// string dataString = "2023-02-06  10:42";
// bool sucesso = DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd  HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None,out DateTime data);


// if (sucesso)
// {
//    System.Console.WriteLine($"Conversão com sucesso!  {data}"); 
// }
// else
// {
//     System.Console.WriteLine($"{dataString} não é uma data válida");
// }

// Console.WriteLine(data);

// // DATE TIME

// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("yyyy-MM-dd HH:mm"));

// Console.WriteLine(data.ToShortTimeString());

// Console.WriteLine(data.ToShortDateString());






// // Formatação de acordo com a cultura

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// // Formatando valores monetários


// decimal valorMonetario = 1590.78M;

// System.Console.WriteLine(valorMonetario.ToString("C2"));
// System.Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// System.Console.WriteLine(porcentagem.ToString("P"));


// int numero = 123456;
// System.Console.WriteLine(numero.ToString("##-##-##"));



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
