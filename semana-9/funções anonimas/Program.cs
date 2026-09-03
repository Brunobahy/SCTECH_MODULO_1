using funções_anonimas;
List<Aluno> alunos = [
    new Aluno("João"),
    new Aluno("Maria"),
    new Aluno("Pedro"),
    new Aluno("Ana")
];

Aluno alunoSelecionado = alunos.Find( aluno => aluno.Nome == "Ana");

Console.WriteLine($"Aluno selecionado: {alunoSelecionado.Nome}");

alunoSelecionado = alunos.Where( aluno => aluno.Nome == "Pedro").FirstOrDefault();
Console.WriteLine($"Aluno selecionado: {alunoSelecionado.Nome}");