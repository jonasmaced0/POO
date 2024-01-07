Console.WriteLine("### Herança - New ###\n");


Aluno aluno = new Aluno();
aluno.Nome = "Maria";
aluno.Curso = "Quimica";
Console.WriteLine(aluno.Saudacao()) ;

Pessoa pessoa = new Pessoa();

pessoa.Nome = aluno.Nome;
pessoa.Saudacao() ;
Console.WriteLine(pessoa.Saudacao());


Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, eu sou o(a) {Nome}";
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao() => $"Oi, eu sou aluno do curso de {Curso}";
}
    