using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Metodos_Construtores.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
            
        }

        public Pessoa(string Nome,string Sobrenome)
        {
            
        }

        private string _nome;
        private int _idade;
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

        public string  Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

         public int Idade 
         { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                   throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
            
        }


    public void Apresentar() 
    {
        System.Console.WriteLine($"Nome: {NomeCompleto}, Idade:{Idade}");
    }

    }

  
}