
int soma = 0, numero =0;

do
{
    System.Console.WriteLine("Digite um numero e (0 para parar");
    numero = Convert.ToInt32(Console.ReadLine());
} while (numero!=0);
System.Console.WriteLine($"O total da soma dos numeros e: {soma}");
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