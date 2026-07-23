// CLASSES

//cria o arquivo com o nome da classe (Aluno no nosso caso)

using poo;


Aluno aluno = new Aluno();

aluno.Nome = "Bruno";
aluno.Endereco = "Rua Y";
aluno.Telefone = "(51) 999999-9999";

Aluno aluno1 = new Aluno();

aluno1.Nome = "gislaine";
aluno1.Endereco = "Rua Y";
aluno1.Telefone = "(51) 999999-9999";

Aluno aluno2 = new Aluno();

aluno2.Nome = "bertrude";
aluno2.Endereco = "Rua Y";
aluno2.Telefone = "(51) 999999-9999";


Turma t1 = new Turma();

t1.MatricularAluno(aluno);
t1.MatricularAluno(aluno1);
t1.MatricularAluno(aluno2);

t1.VerTurma();
