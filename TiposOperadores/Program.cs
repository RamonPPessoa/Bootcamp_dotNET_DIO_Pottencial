// OPERADORES CONDICIONAIS

System.Console.WriteLine("----------- Inicio de operadores lógicos -------------------");

 int quantidadeNoEstoque = 15;
 int quantidadeDeCompra = 0;
 bool vendaPossivel = quantidadeDeCompra > 0 && quantidadeNoEstoque >= quantidadeDeCompra;

 System.Console.WriteLine($"\nQuantidade no estoque: {quantidadeNoEstoque}");
 System.Console.WriteLine($"Quantidade  de compra: {quantidadeDeCompra}");
 System.Console.WriteLine($"É possivel efetuar a venda?  {vendaPossivel}");

if(quantidadeDeCompra == 0) 
{

}

 if (vendaPossivel)
 {
  System.Console.WriteLine("Venda efetuada ");
 }
 else if(vendaPossivel)
 {
  System.Console.WriteLine("Desculpe,no momento não temos a quanitdade solicitada em nosso estoque");
 }
 else
 {
  System.Console.WriteLine("desculpe não temos a quantidade solicitada");
 }

System.Console.WriteLine(" ----------- Fim de operadores lógicos ---------------");


// Convertendo tipos com segurança

System.Console.WriteLine("Convertendo tipos de maneira segura");
string y = "10-c";

int x = 0;
int.TryParse(y, out x);

System.Console.WriteLine(x);
System.Console.WriteLine("Conversão com sucesso");

//Cast implicito
int n1 = 5;
double n2 = n1;

System.Console.WriteLine(n2);


// Conversão para string
int inteiro = 5;
string a = inteiro.ToString();

Console.WriteLine(a);



// Cast - casting

//int a = Convert.ToInt32(null); // Mais apropriado usar o Convert pois o mesmo aceita valores nulos (null)

//Casting convertendo tipos de variáveis



 //int a = int.Parse("5"); // o Parse não aceita null
  //Console.WriteLine(a);




// int n1 = 10;
// int n2 = 5;

// int result = n1 + n2;

//  result +=5;

//  Console.WriteLine(result);

