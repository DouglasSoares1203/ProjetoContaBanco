using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoContaBanco.Classes
{
    class ReservaBancaria : Contas
    {
        private string listaDesejos { get; set; }
        private int juros { get; set; }


        public int Juros 
        {
            get{ return this.juros; } 
            set{ this.juros = value; }      
        }

        public string ListaDesejos 
        {
            get{ return this.listaDesejos; } 
            set{ this.listaDesejos = value; }      
        }

        public ReservaBancaria(double balanco) : base()
        {
            this.juros = 3;
            this.balanco = balanco;
            tipoConta = "Reserva Bancária";
        }
    }
}