using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoContaBanco.Classes
{
     class Corrente : Contas
    {
        private double balancoMin;
        private double balancoMax;

        public double BalancoMin
        {
            get { return this.balancoMin; } 
        } 

        public double? BalancoMax
        {
            get { return this.balancoMax; } 
        }
        
        public  Corrente(double balanco) : base()
        {
            this.balancoMin = 500;
            this.balancoMax = 1000000000000;
            this.balanco = balanco;
            tipoConta = "Conta Corrente";

        }
    }
}