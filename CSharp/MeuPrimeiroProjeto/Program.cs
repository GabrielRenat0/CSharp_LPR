using System;

namespace MeuPrimeiroProjeto
{
    class Program 
    {
        static void Main(string[] args)
        {
         ContaCorrente conta1 = new ContaCorrente ("Gabriel Renato", 12345 , 6789, 1000);
         bool sacar_conta1 = conta1.Sacar(100) ;
         
         Console.WriteLine ("*******************");
         Console.WriteLine (" A conta é do(a) " + conta1.Titular) ;
         Console.WriteLine (" A agencia é " + conta1.Agencia) ;
         Console.WriteLine (" A conta é " + conta1.Conta) ; 
         Console.WriteLine (" O saldo é " + conta1.Saldo) ;
         Console.WriteLine ("*******************");

         ContaCorrente conta2 = new ContaCorrente ("Fabio Henrique The Second", 54321 , 9876 , 2750);
         bool sacar_conta2 = conta2.Sacar(100) ;
         
         Console.WriteLine ("*******************");
         Console.WriteLine (" A conta é do(a) " + conta2.Titular) ;
         Console.WriteLine (" A agencia é " + conta2.Agencia) ;
         Console.WriteLine (" A conta é " + conta2.Conta) ; 
         Console.WriteLine (" O saldo é " + conta2.Saldo) ;
         Console.WriteLine ("*******************");

         ContaCorrente conta3 = new ContaCorrente ("Bruno Nunes Teixeira" , 10101 , 9371 , 1500);
         bool sacar_conta3 = conta3.Sacar(100) ;
    
         Console.WriteLine ("*******************");
         Console.WriteLine (" A conta é do(a) " + conta3.Titular) ;
         Console.WriteLine (" A agencia é " + conta3.Agencia) ;
         Console.WriteLine (" A conta é " + conta3.Conta) ; 
         Console.WriteLine (" O saldo é " + conta3.Saldo) ;
         Console.WriteLine ("*******************");

        }
    }
}
