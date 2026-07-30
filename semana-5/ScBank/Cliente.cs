using System.Reflection;

namespace ScBank
{
    public class Cliente : Pessoa
    {
        public string Endereco { get; set; }

        public void Preencher()
        {
            Console.WriteLine("Digite Nome do cliente:");
            Nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o Telefone:");
            Telefone = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o Endereço:");
            Endereco = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o Email:");
            Email = Console.ReadLine();
            while (!ValidaEmail())
            {
                Console.WriteLine("Email invalido Digite novamente: ");
                Email = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Digite o CPF:");
            Cpf = Console.ReadLine();
            while (!ValidaCpf())
            {
                Console.WriteLine("CPF invalido Digite novamente: ");
                Cpf = Console.ReadLine();
            }

        }

        public void Imprimir()
        {
            Console.WriteLine($"\n\n-------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cpf: {Cpf}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"-------------------\n\n");
        }
    }
}