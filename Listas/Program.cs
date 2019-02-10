using System;
using System.Collections.Generic;
using System.Globalization;
namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trabalhador> trabalhadores = new List<Trabalhador>();
            Console.Write("Quantos trabalhadores você quer registrar? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Trabalhador #"+i);
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                trabalhadores.Add(new Trabalhador(id, nome, salario));   
            }

            Console.WriteLine("Entre com o id do funcionario que deseja aumentar o salario: ");
            int IdFunc = int.Parse(Console.ReadLine());
            Trabalhador trab = trabalhadores.Find(x => x.Id == IdFunc);
            while (trab == null)
            {
                Console.WriteLine("nao existe trabalhador com o Id informado, digite um Id Válido ! ");
                IdFunc = int.Parse(Console.ReadLine());
                trab = trabalhadores.Find(x => x.Id == IdFunc);
             
            }
            Console.WriteLine("Digite a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trab.AumentarSalario(porcentagem);

            foreach (object obj in trabalhadores)
            {
                Console.WriteLine("Salario atualizado");
                Console.WriteLine(obj);
            }

        }
    }
}
