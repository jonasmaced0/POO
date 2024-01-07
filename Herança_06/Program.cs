Console.WriteLine("### Herança - virtual e override ###\n");


Gato gato = new Gato() { Nome = "Petucho"};
gato.ExibeNome();

Cachorro cachorro = new Cachorro() { Nome = "Feijão" };
cachorro.ExibeNome();


Console.ReadKey();

// classe base

public class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

// classe derivada

public class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"Eu sou um gato. Meu nome é : {Nome}");
    }
}

public class Cachorro : Animal
{

}