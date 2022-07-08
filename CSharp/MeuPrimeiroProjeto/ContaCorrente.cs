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
  public bool Sacar (double valorSaque)
  {
    if (this.Saldo >= valorSaque)
    {
    this.Saldo = this.Saldo - valorSaque;
    return true ;
    }
    return false ;
  }

public bool Depositar (double valorDepositar)
{
  this.Saldo = this.Saldo + valorDepositar;
  return true ;
}


}