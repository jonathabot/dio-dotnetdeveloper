using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_fundamentos.Models
{
    public class Pessoa
    {
        // atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        //metodos
        public void Apresentar() {
            Console.WriteLine($"Olá, eu sou o {Nome} e tenho {Idade} anos");
        }
    }
}