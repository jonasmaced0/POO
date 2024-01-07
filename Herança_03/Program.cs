Console.WriteLine("### Herança - Construtores ###\n");


Aluno aluno1 = new Aluno();
Aluno aluno2 = new Aluno("Jonas");


Console.ReadKey();

class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("O construtor da classe Pessoa com parametro");
    }
}

class Aluno : Pessoa
{
    public Aluno() : base ()
    {
        Console.WriteLine("construtor da classe Aluno");
    }
    public Aluno(string nome) : base (nome) 
    {
        Console.WriteLine("O construtor da classe Aluno com parametro");
    }
}


// uma instancia da classe derivada irá chamar primeiro o método construtor da classe base e depois da 
// classe derivada, esse é o comportamento padrão






















