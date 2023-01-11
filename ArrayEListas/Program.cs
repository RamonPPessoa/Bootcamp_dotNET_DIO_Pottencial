


List<string> listaDeString = new List<string>();

listaDeString.Add("AM");
listaDeString.Add("AC");
listaDeString.Add("AP");


for (int i = 0; i <   listaDeString.Count; i++)
{
    Console.WriteLine($"{i} - {listaDeString[i]}");
}

Console.WriteLine("***********LISTA COM FOREACH********************");
int contadorForeach = 0;
foreach(string item in listaDeString)
{
    Console.WriteLine($"{contadorForeach} - {item}");
    contadorForeach++;
}


// int[] arrayInteiro = new int[3];

// arrayInteiro[0] = 10;
// arrayInteiro[1] = 20;
// arrayInteiro[2] = 30;


// int[] arrayInteiroDobro = new int[arrayInteiro.Length * 2];

// //Array.Resize(ref arrayInteiro,arrayInteiro.Length * 2);
// for (int i =  0; i < arrayInteiro.Length; i++) 
// {
//     System.Console.WriteLine($"Posicao Nº: {i} = {arrayInteiro[i]}");
// }

// System.Console.WriteLine("Utilizando o foreach");
// int countForeach = 0;
// foreach (var item in arrayInteiro)
// {
//     System.Console.WriteLine($"Posição Nº{countForeach} =  {item}");
//     countForeach++;
// }