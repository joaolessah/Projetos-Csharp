using System.Collections.Generic;
using BancoCSharp.Entities.Enums;

namespace BancoCSharp.Entities
{

    // classe só serve para herança, herdar dela como base para outras, não posso criar um objeto a partir dela
    public abstract class ContaBancaria
    {
        #region Atributos
        public Titular Titular { get; set; } // preciso instanciar um objeto do tipo titular
        public double Saldo { get; private set; }
        public DateTime DataDeAbertura { get; private set; }
        protected List<Movimentacao> Movimentacoes { get; set; }
        public double ChequeEspecial {get; set;}

// o atributo sendo protected a classe filha pode alterra
        protected readonly double VALOR_MINIMO = 10.0; // propriedade privada que só a conta acessa, somente para leitura, é uma constante

        #endregion

        #region Construtores
        public ContaBancaria(Titular titular, double saldoDeAbertura)
        {
            Titular = titular;
            Saldo = saldoDeAbertura;
            DataDeAbertura = DateTime.Now;
            ChequeEspecial = 200.00;
            Movimentacoes= new List<Movimentacao>(){
                new Movimentacao (TipoMovimentacao.AberturaDeConta, saldoDeAbertura)            
            };
            
           
        }
        public ContaBancaria(Titular titular)
        {
            Titular = titular;
            Saldo = 0;
            DataDeAbertura = DateTime.Now;
            ChequeEspecial = 200.00;

            Movimentacoes= new List<Movimentacao>(){
                new Movimentacao (TipoMovimentacao.AberturaDeConta, Saldo)            
            };;

        }


        #endregion

        #region Metodos

        public void Depositar(double amount)
        {

            if (amount < VALOR_MINIMO)
            {
                //lançando uma exceção 
                throw new Exception("O valor mínimo para depositar é R$" + VALOR_MINIMO);
            }
            Saldo += amount;
            Movimentacoes.Add(new Movimentacao (TipoMovimentacao.Deposito, amount));
        }
        public double Sacar(double amount)
        {

            if (amount < VALOR_MINIMO)
            {
                //lançando uma exceção 
                throw new Exception("O valor mínimo para saque é R$" + VALOR_MINIMO);
            }

            else if (Saldo < amount){

                if(Saldo > 0.0){
                    double dif = amount - Saldo;
                    ChequeEspecial -= dif;
                    Movimentacoes.Add(new Movimentacao (TipoMovimentacao.ChequeEspecial, dif));
                }
                else{
                    if(ChequeEspecial > 0){
                        ChequeEspecial -= amount;
                        Movimentacoes.Add(new Movimentacao (TipoMovimentacao.ChequeEspecial, amount));
                    }
                    return Saldo = 0;
                }
                 
                 
            }
            
            Saldo -= amount;
            Movimentacoes.Add(new Movimentacao (TipoMovimentacao.Saque, amount));

            
            
            return amount;
        }

        public void Transferencia(ContaBancaria contaDestino, double amount)
        {
            if (amount < VALOR_MINIMO)
            {
                throw new Exception("Valor mínimo para transferência é de R$" + VALOR_MINIMO);
            }
            else if (amount > Saldo)
            {
                throw new Exception("Saldo insuficiente para transferência, Saldo atual é de R$" + Saldo);

            }

            contaDestino.Depositar(amount); 
            Saldo -= amount;
            Movimentacoes.Add(new Movimentacao (TipoMovimentacao.Transferencia, amount));

        }

        public abstract void ImprimirExtrato();
        // todas as classes filhas vão ter que implementar uma sobrescrição da classe imprimir
        // virtual eu posso usar o padrão ou sobrescrever

        #endregion
    }
}