using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoContaBanco.Classes
{
    class Poupanca : Contas
    {
        private int poupancaJuros;
        //private int balancoMin;
        private int vezesRetirada;


        public int PoupancaJuros
        {
            get{return this.poupancaJuros;}
        }

        private int VezesRetirada
        {
            get{return this.vezesRetirada;}
        }

        public Poupanca(double balanco) : base()
        {
            poupancaJuros = 10;
            this.balanco = balanco;
            tipoConta = "Conta Poupança";
        }
    }
}