using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoContaBanco
{
    class Contas
    {
        private string primeiroNome;    
        private string segundoNome;

        private double numeroConta;
        protected string tipoConta;

        protected double balanco;
        protected double deposito;
        protected double retirada;


        public string TipoConta 
        { 
            get{return this.tipoConta;} 
        }

        public double Retirada
        { 
            get{ return this.retirada; } 
            set{ this.retirada = value; } 
        }
        
        public double Deposito 
        { 
            get{ return this.deposito; } 
            set{ this.deposito = value; } 
        }

        public double NumeConta 
        { 
            get{ return this.numeroConta; } 
        }

        public double Bal 
        { 
            get{ return this.balanco; }  
        }

        public Contas()
        {
            primeiroNome = "Douglas";
            segundoNome = "Aquino";
        }
        
        public virtual double NumeroConta()
        {
            Random rand = new Random();
            this.numeroConta = rand.Next(100000000, 1000000000);
            return numeroConta;
        }

        public virtual double Balanco()
        {
            balanco = balanco + deposito - retirada;
            deposito = 0;
            retirada = 0;
            return balanco;
        }

        public virtual double BalancoDeposito(double input)
        {
            deposito = input;
            retirada = 0;
            balanco = balanco + deposito - retirada;
            return balanco;
        }

        public virtual double BalancoRetirado(double input)
        {
            retirada = input;
            deposito = 0;
            balanco = balanco + deposito - retirada;
            return balanco;
        }

         public virtual void ExibirMenu()
        {
            Console.WriteLine("Fake BR Banco LTDA.\nBem vindo ao seu Banco online, " + primeiroNome + " " + segundoNome);
            Console.WriteLine("Por favor, escolha as op????es abaixo:\n1.Ver informa????es do cliente\n2.Ver balan??o de contas:");
            Console.WriteLine("     2A.Corrente\n     2B.Poupan??a\n     2C.ReservaBancaria");
            Console.WriteLine("3.Deposito Fundos:\n     3A.Corrente\n     3B.RerservaBancaria\n     3C.Poupan??a");
            Console.WriteLine("4.retirada Fundos:\n     4A.Corrente\n     4B.RerservaBancaria\n     4C.Poupan??a");
            Console.WriteLine("5.Exit");
        }

        public string InformarCliente()
        {
            string informarcliente = ("Titular da Conta: " + primeiroNome + " " + segundoNome);
            return informarcliente;
        }
    }
}