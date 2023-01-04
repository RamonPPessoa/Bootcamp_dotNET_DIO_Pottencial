Console.WriteLine("======================MENU==============================");

 string opcao;
 bool exibirMenu = true;

while (exibirMenu)
 {
     Console.Clear();
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("Cadastrar");
    Console.WriteLine("Buscar");
     Console.WriteLine("Apagar");
    Console.WriteLine("Encerrar");

     opcao = Console.ReadLine();
     switch (opcao)
     {
         case "1":
             Console.WriteLine("Cadastrar");
             break;

        case "2":
          Console.WriteLine("Buscar");
             break;

         case "3":
              Console.WriteLine("Apager");
             break;

         case "4":
              Console.WriteLine("Encerrar");
              exibirMenu = false;
             break;

        
         default:
          Console.WriteLine("Opcao Inválida");
            break;
     }
 }





//System.Console.WriteLine("================ DO While =================================");

// int soma = 0, numero =0;

// do
// {
//     System.Console.WriteLine("Digite um numero e (0 para parar");
//     numero = Convert.ToInt32(Console.ReadLine());
// } while (numero!=0);
// System.Console.WriteLine($"O total da soma dos numeros e: {soma}");

//System.Console.WriteLine("================ Fim DO While =================================");

/*int numero = 4;
int i =0;
while (i <=10)
{
    System.Console.WriteLine($"{i}º Execução: {numero} x {i} ={numero * i}");
    i++;
}*/

/*int numero = 5;
for (int i = 0; i<= 10;i++)
{
    System.Console.WriteLine($"{numero} x {i} ={numero * i}");
}*/