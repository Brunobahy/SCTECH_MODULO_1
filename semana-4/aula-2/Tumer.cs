namespace poo
{
    public class Turma
    {
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public void MatricularAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            aluno.RealizarMatricula();
        }

        public void VerTurma()
        {
            foreach(Aluno aluno in Alunos)
            {
                Console.WriteLine("****************");
                aluno.ExibirAluno();
                Console.WriteLine("****************");
            }
        }
    
    }
}