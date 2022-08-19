namespace BancoCSharp.Entities
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Titular titular)
        : base(titular)
        {
        }

        public ContaCorrente(Titular titular, double saldoDeAbertura)
        : base(titular, saldoDeAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("***** Extrato Conta Corrente *****");
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