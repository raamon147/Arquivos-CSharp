using System;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serao alugados: ");
            int n = int.Parse(Console.ReadLine());
            Hospedes[] hospedes = new Hospedes[11];

            while (n> hospedes.Length)
            {
                Console.WriteLine("O Hotel só possui " + (hospedes.Length)  + " Quartos, Escolha apenas esses !");
                n = int.Parse(Console.ReadLine());
            }
            
            for (int i = 1; i <= n; i++)
            {
                
                Console.WriteLine("Hospede #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto : ");
                int quarto = int.Parse(Console.ReadLine());


                while (quarto > hospedes.Length || quarto ==0)
                {
                    Console.WriteLine("Quarto inexistente, digite um quarto entre 1 e "
                        + hospedes.Length);
                    quarto = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();


                while (hospedes[quarto] != null)
                {
                    Console.WriteLine("quarto ocupado, digite outro");
                    quarto = int.Parse(Console.ReadLine());
                    while (quarto > hospedes.Length)
                    {
                        Console.WriteLine("Quarto inexistente, digite um quarto entre 1 e "
                        + hospedes.Length);
                        quarto = int.Parse(Console.ReadLine());
                    }
                }
                hospedes[quarto] = new Hospedes(nome, email, quarto);
                }

            Console.WriteLine("Quartos ocupados");
            for (int i = 0; i <= 10; i++)
            {
                if(hospedes[i] != null)
                {
                    
                    Console.WriteLine(hospedes[i].ToString());
                }
            }
        }
    }
}
