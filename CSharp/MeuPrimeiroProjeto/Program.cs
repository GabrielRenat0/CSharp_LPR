using System;

namespace MeuPrimeiroProjeto
{
    class Program 
    {
        static void Main(string[] args)
        {
         ContaCorrente conta = new ContaCorrente ("Gabriel Renato", 12345 , 6789, 1000);
         
         Console.WriteLine ("*******************");
         Console.WriteLine (" A conta é do(a) " + conta.Titular) ;
         Console.WriteLine (" A agencia é " + conta.Agencia) ;
         Console.WriteLine (" A conta é " + conta.Conta) ; 
         Console.WriteLine (" O saldo é " + conta.Saldo) ;
         Console.WriteLine ("*******************");

         ContaCorrente conta2 = new ContaCorrente ("Fabio Henrique The Second", 54321 , 9876 , 2750);
         
         Console.WriteLine ("*******************");
         Console.WriteLine (" A conta é do(a) " + conta2.Titular) ;
         Console.WriteLine (" A agencia é " + conta2.Agencia) ;
         Console.WriteLine (" A conta é " + conta2.Conta) ; 
         Console.WriteLine (" O saldo é " + conta2.Saldo) ;
         Console.WriteLine ("*******************");

         ContaCorrente conta3 = new ContaCorrente ("Bruno Nunes Teixeira" , 10101 , 9371 , 150069);
    
         Console.WriteLine ("*******************");
         Console.WriteLine (" A conta é do(a) " + conta3.Titular) ;
         Console.WriteLine (" A agencia é " + conta3.Agencia) ;
         Console.WriteLine (" A conta é " + conta3.Conta) ; 
         Console.WriteLine (" O saldo é " + conta3.Saldo) ;
         Console.WriteLine ("*******************");
        }
    }
}
