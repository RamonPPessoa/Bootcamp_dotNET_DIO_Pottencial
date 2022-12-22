using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintax_Tipos_de_Dados.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome}, e tenho {Idade}");
        }
    }
}