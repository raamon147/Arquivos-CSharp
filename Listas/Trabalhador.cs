using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Listas
{
    class Trabalhador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Trabalhador (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
           
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }
        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("f2",CultureInfo.InvariantCulture); 
        }
    }
}
