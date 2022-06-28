public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Conta;
    public double Saldo;

    public ContaCorrente (string Titular, int Agencia , int Conta , double Saldo)
    {
      this.Titular = Titular;
      this.Agencia = Agencia;
      this.Conta = Conta; 
      this.Saldo = Saldo;
    }

}