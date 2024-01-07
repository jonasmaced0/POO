
using ExercicioHerança;

Console.WriteLine("### Exercício - Herança ###");

/*  
 
 Herança - Exercício

Escrever um programa onde devemos usar os conceitos de abstração, encapsulamento e herança para
expressar o comportamento de contas bancárias considerando o seguinte cenário :

Em um banco temos clientes que possuem contas que são identificadas por um Número e Nome do cliente.
As operações que serão permitidas são as operações básicas de depositar , sacar e exibir o saldo.

Devemos considerar 3 tipos de contas:

1- contas correntes comuns : São contas comuns dos clientes e realizam todas as operações básicas

2- contas de poupança : São contas especificas que se destacam por possuírem juros mensais que são
aplicados ao saldo da conta

3- contas de investimento : São contas especificas que se destacam por possuir uma taxa de remuneração que
é aplicado ao saldo da conta e uma taxa de imposto que é descontado do saldo da conta

Para simplificar o exercício considere as seguintes premissas:

a- O saldo inicial das contas é zero;

b- O juros da conta de poupança é 0,5% e os rendimentos devem ser calculados ao se efetuar um deposito e
deve ser acrescido ao saldo da conta;

c- A taxa da conta de investimento é 0,9% é deve ser aplicada a cada depósito e acrescida ao saldo;

d- O imposto da conta de investimento é 0,1% e deve ser aplicado a cada saque na conta e debitado do saldo;
e- As contas de poupança e de investimento não permitem que o saldo da conta fique negativo ;
 
 */

// Testando com o programa criado:

Console.WriteLine("\nConta Corrente: nº 111 - Titular: Maria");

Conta conta1 = new Conta();
conta1.Titular = "Maria";
conta1.Numero = 111;
Console.WriteLine("Depositando R$1000,00 na conta Corrente ");
conta1.Deposito(1000);
Console.WriteLine($"O saldo da conta Corrente é de R$ {conta1.Saldo}");
Console.WriteLine("Sacando R$3000,00 da conta Corrente");
conta1.Sacar(3000);
Console.WriteLine($"O saldo da conta Corrente é de R$ {conta1.Saldo}");
Console.ReadKey();

Console.WriteLine("\nConta Poupança: nº 222 - Titular: João");

ContaPoupanca conta2 = new ContaPoupanca();
conta2.Titular = "João";
conta2.Numero = 222;
Console.WriteLine("Depositando R$1000,00 na conta Poupança");
conta2.Deposito(1000);
Console.WriteLine($"O saldo da conta Poupança é de R$ {conta2.Saldo}");
Console.WriteLine("Sacando R$3000,00 da conta Poupança");
conta2.Sacar(3000);
Console.WriteLine($"O saldo da conta Poupança é de R$ {conta2.Saldo}");
Console.ReadKey();

Console.WriteLine("\nConta Poupança: nº 333 - Titular: Pedro");

ContaInvestimento conta3 = new ContaInvestimento();
conta3.Titular = "Pedro";
conta3.Numero = 333;
Console.WriteLine("Depositando R$1000,00 na conta de Investimento ");
conta3.Deposito(1000);
Console.WriteLine($"O saldo da conta de Investimento é de R${conta3.Saldo}");
Console.WriteLine("Sacando R$300,00 da conta de Investimento");
conta3.Sacar(300);
Console.WriteLine($"O saldo da conta de Investimento é de R${conta3.Saldo}");
Console.WriteLine("Sacando R$3000,00 da conta de Investimento");
conta3.Sacar(3000);
Console.WriteLine($"O saldo da conta de Investimento é de R${conta3.Saldo}");
Console.ReadKey();