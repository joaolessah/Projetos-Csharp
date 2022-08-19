using BancoCSharp.Entities.Enums;

namespace BancoCSharp.Entities
{
    public class Movimentacao
    {
        // 02/04/2022 as 19:09hrs - SAQUE    -R$ 10.00
        // 02/04/2022 as 19:30hrs - DEPOSITO  R$ 10.00
        // só a classe acessa
        private DateTime DataHoraMovimentacao { get; set; }
        private TipoMovimentacao TipoMovimentacao {get; set;}
        private double Valor {get; set;}

        public Movimentacao (TipoMovimentacao tipoMovimentacao, double valor){
            TipoMovimentacao = tipoMovimentacao;
            Valor = valor;
            DataHoraMovimentacao = DateTime.Now;

        }

        public override string ToString()
        {
            var valor = (this.TipoMovimentacao == TipoMovimentacao.Saque || this.TipoMovimentacao == TipoMovimentacao.Transferencia || this.TipoMovimentacao == TipoMovimentacao.ChequeEspecial)  // if
            ? "-R$ "+ Valor // se for true executa isso
            : "R$ " + Valor;// false executa isso

            return $"{DataHoraMovimentacao} | {TipoMovimentacao} | {valor}";
        }
    }
}