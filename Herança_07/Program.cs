Console.WriteLine("### Herança -  modificador sealed ###\n");

// Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela.


Console.ReadKey();

class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe2 : Classe1
{
    protected override void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}