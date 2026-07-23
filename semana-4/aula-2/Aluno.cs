namespace poo
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome {get;set;}
        //Se você escrever prop ele já escreve o snipset;
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public void RealizarMatricula()
        {
            //ToDo: Fazer matricula
            Matricula = new Random().Next();
            Console.WriteLine($"Matricula do aluno {Nome} realizada!");
        }

        public void ConsultarNotas()
        {
            Console.WriteLine($"As notas do {Nome} são: (implementar isso no futuro)");
        }
        public void ExibirAluno()
        {
            Console.WriteLine("Matricula do aluno: "+Matricula);
            Console.WriteLine("Nome do aluno: "+Nome);
            Console.WriteLine("Telefone do aluno: "+Telefone);
            Console.WriteLine("Endereço do aluno: "+Endereco);
        }
    }
}