namespace ScBank
{
    public class Funcionario :Pessoa
    {
        public int Matricula { get; set; }
        public string Funcao { get; set; }

        public Funcionario()
        {
            Matricula = new Random().Next();
        }

        public void Preencher()
        {
            Console.WriteLine("Digite Nome do Funcionario:");
            Nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o Telefone:");
            Telefone = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite a Função:");
            Funcao = Console.ReadLine();
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
            Console.WriteLine($"Função: {Funcao}");
            Console.WriteLine($"-------------------\n\n");
        }
    }
}