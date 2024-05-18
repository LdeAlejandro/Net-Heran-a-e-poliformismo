using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca_polimorfismo.Models;

namespace Heranca_polimorfismo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        //overrided de Pessoa  Apresentar() para trocar o que o metodo faz.
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome sou o professor {Nome} de {Idade} anos. salario: {Salario}.");
        }
    }
}
