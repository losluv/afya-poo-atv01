namespace ex_03_conta_corrente_uni;

public class Conta_Corrente_Universitaria
{

//atributos
public readonly int Num_Da_Conta;
private string titular;
private int saldo;
private int limite_cheque_especial;

//construtores
public Conta_Corrente_Universitaria(int num_Da_Conta, string titular)
{
    this.Num_Da_Conta = num_Da_Conta;
    this.titular = titular;
    this.saldo = 0;
    this.limite_cheque_especial = 500;

}

//metodos

public void Depositar(int valor)
{
    if (valor > 0)
    {
        this.saldo += valor;
    }
    else
    {
        Console.WriteLine("Valor de depósito inválido.");
    }
}

public void Sacar(int valor)
{
    if (valor > 0)
    {
        if (saldo + limite_cheque_especial >= valor)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("saldo insuficiente");
        }
    }
    else
    {
        Console.WriteLine("valor inválido");
    }
}

public void ToString()
{
    Console.WriteLine("número da conta :" + Num_Da_Conta);
    Console.WriteLine("titular:"+ titular);
    Console.WriteLine("Saldo: " + saldo);
    Console.WriteLine("Limite do Cheque Especial: " + limite_cheque_especial);
}

}


