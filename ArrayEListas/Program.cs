﻿

int[] arrayInteiro = new int[3];

arrayInteiro[0] = 10;
arrayInteiro[1] = 20;
arrayInteiro[2] = 30;

for (int i =  0; i < arrayInteiro.Length; i++) 
{
    System.Console.WriteLine($"Posicao Nº: {i} = {arrayInteiro[i]}");
}

System.Console.WriteLine("Utilizando o foreach");
int countForeach = 0;
foreach (var item in arrayInteiro)
{
    System.Console.WriteLine($"Posição Nº{countForeach} =  {item}");
    countForeach++;
}