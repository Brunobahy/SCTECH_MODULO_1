namespace ScBank
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; protected set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public bool ValidaCpf()
        {
            return Cpf.Length == 11;
        }
        public bool ValidaCpf(string novoCpf)
        {
            return novoCpf.Length == 11;
        }

        public void SetCpf(string novoCpf)
        {
            if (!ValidaCpf(novoCpf))
            {
                Console.WriteLine("O Cpf passado é invalido!");
            }
            else
            {
                Console.WriteLine("CPF alterado!");
                Cpf = novoCpf;
            }
        }

        public bool ValidaEmail()
        {
            return Email.Contains('@');
        }
    }
}
