Console.WriteLine("### Herança ###\n");

Funcionario funcionario1 = new Funcionario();

funcionario1.Nome = "José";
funcionario1.Email = "josemarcos@gmail.com";
funcionario1.Salario = 4000;
funcionario1.Empresa = "Google";

Console.WriteLine("\nFuncionario");
Console.WriteLine(funcionario1.Nome);
Console.WriteLine(funcionario1.Salario);

funcionario1.Identificar();

Aluno aluno1 = new Aluno();

aluno1.Nome = "Marcos";
aluno1.Email = "marcospedro@gmail.com";
aluno1.Nota = 10;
aluno1.Curso = "História";

Console.WriteLine("\nAluno");
Console.WriteLine(aluno1.Nome);
Console.WriteLine(aluno1.Curso);
aluno1.Identificar();


Console.ReadLine();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }

    public decimal Salario { get; set; }

}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}
