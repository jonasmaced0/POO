Console.WriteLine("### Herança ###\n");

// modificadores : public, private, internal, protected, e protected internal

ClasseDerivada cd = new();
cd.VerificaAcesso();


Console.ReadKey();


public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_Internal_Membro();
        //Private_Membro();

        Console.WriteLine("\nAcessando o campo privado da classe base atavés da propriedade publíca");
        var soma = public_var + internal_var + protected_var + Private_var;
        Console.WriteLine($"\nA soma total é de: {soma}");
    }
}

public class ClasseBase
{
    // campos

    public int public_var = 1;
    internal int internal_var = 2;
    protected int protected_var = 3;
    private int private_var = 4;

    // propriedade

    public int Private_var 
        { 
        get { return private_var; }
        set { private_var = value; }
        }

    // métodos
    public void Public_Membro()
    {
        Console.WriteLine("Classe Base - Método Public");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("Classe Base - Método Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("Classe Base - Método Internal");
    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("Classe Base - Método Protected Internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("Classe Base - Método Private");
    }

}



// resumindo, através de uma classe derivada, eu não consigo acessar um método privado, porém eu consigo
// acessar uma campo privado se eu utilizar uma propriedade publica do campo privado, nada mais nada menos
// do que usar o encapsulamento.