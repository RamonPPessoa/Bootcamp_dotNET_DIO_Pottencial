using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Metodos_Construtores.Models
{
    public class Pessoa
    {

        private string _nome;
         public string Nome
         {

            // body expressions
            get => _nome.ToUpper();
            


            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O campo nome não pode ser vazio");
                }
                _nome = value;
            }
            
        }
         public int Idade { get; set; }


    public void Apresentar() 
    {
        System.Console.WriteLine($"Nome: {Nome}, Idade:{Idade}");
    }

    }

  
}