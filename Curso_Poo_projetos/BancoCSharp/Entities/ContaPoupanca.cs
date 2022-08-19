namespace BancoCSharp.Entities
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Titular titular) 
        : base(titular)
        {
        }

        public ContaPoupanca(Titular titular, double saldoDeAbertura) 
        : base(titular, saldoDeAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("***** Extrato Conta Poupança *****");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            Console.WriteLine("Gerado em: " + DateTime.Now);
            Console.WriteLine();

            foreach(var movimentacao in Movimentacoes){
                Console.WriteLine(movimentacao.ToString());
            }
            Console.WriteLine("Saldo atual: R$ " + Saldo);
            Console.WriteLine("Cheque especial: R$ " + ChequeEspecial);
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine("********* Fim do extrato *********");
            Console.WriteLine("**********************************");
            Console.WriteLine();
        }        
    }
}