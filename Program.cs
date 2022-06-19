
using ProjetoContaBanco;
using ProjetoContaBanco.Classes;

namespace Banco
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Contas clinte = new Contas();

            Corrente corrente = new Corrente(2000);
            corrente.NumeroConta();

            ReservaBancaria reserva = new ReservaBancaria(500);
            reserva.NumeroConta();

            Poupanca poupanca = new Poupanca(18000);
            poupanca.NumeroConta();

            string fluxocontacorrente = ("Número da Conta: " + corrente.NumeConta);
            string fluxoreservabancaria = ("Número da Conta: " + reserva.NumeConta);
            string fluxocontapoupanca = ("Número da Conta: " + poupanca.NumeConta);
            string fluxoclienteinformacao = (clinte.InformarCliente());
            string tipocontacorrente = (corrente.TipoConta);
            string tiporeservabancaria = (reserva.TipoConta);
            string tipocontapoupanca = (poupanca.TipoConta);


            using (StreamWriter correnteverificacao = new StreamWriter("CorrenteVerificação.txt",true))
            {
                correnteverificacao.WriteLine(tipocontacorrente);
                correnteverificacao.WriteLine(fluxoclienteinformacao);
                correnteverificacao.WriteLine(fluxocontacorrente);
            }

            using (StreamWriter reservaverificacao = new StreamWriter("ReservaVerificação.txt",true))
            {
                reservaverificacao.WriteLine(tiporeservabancaria);
                reservaverificacao.WriteLine(fluxoclienteinformacao);
                reservaverificacao.WriteLine(fluxoreservabancaria);
            }

            using (StreamWriter poupancaverificacao = new StreamWriter("PoupançaVerificação.txt",true))
            {
                poupancaverificacao.WriteLine(tipocontapoupanca);
                poupancaverificacao.WriteLine(fluxoclienteinformacao);
                poupancaverificacao.WriteLine(fluxocontapoupanca);
            }

            bool teste = false;


            do
            {
                
                string depositoCorrentePara = ($"Transaction: +${corrente.Deposito} at {DateTime.Now.ToString()} Current Balanço: ${corrente.Bal}");
                string RetiradaCorrentePara = ($"Transaction: -${corrente.Retirada} at {DateTime.Now.ToString()} Current Balanço: ${corrente.Bal}");
                string depositoReservaPara = ($"Transaction: +${reserva.Deposito} at {DateTime.Now.ToString()} Current Balanço: ${reserva.Bal}");
                string RetiradaReservaPara = ($"Transaction: -${reserva.Retirada} at {DateTime.Now.ToString()} Current Balanço: ${reserva.Bal}");
                string depositoPoupancaPara = ($"Transaction: +${poupanca.Deposito} at {DateTime.Now.ToString()} Current Balanço: ${poupanca.Bal}");
                string RetiradaPoupancaPara = ($"Transaction: -${poupanca.Retirada} at {DateTime.Now.ToString()} Current Balanço: ${poupanca.Bal}");

                using(StreamWriter resumoDeFluxoContaCorrente = new StreamWriter("ResumoCorrente.txt",true))
                {
                    if (corrente.Deposito > 0)
                    {
                        resumoDeFluxoContaCorrente.WriteLine(depositoCorrentePara);
                        corrente.Deposito = 0;
                    }

                    if (corrente.Retirada > 0)
                    {
                        resumoDeFluxoContaCorrente.WriteLine(RetiradaCorrentePara);
                        corrente.Retirada = 0;
                    }
                }

                using(StreamWriter resumoDeFluxoReservaBancaria = new StreamWriter("ResumoReservaBancaria.txt",true))
                {
                    if (reserva.Deposito > 0)
                    {
                        resumoDeFluxoReservaBancaria.WriteLine(depositoReservaPara);
                        reserva.Deposito = 0;
                    }

                    if (reserva.Retirada > 0)
                    {
                        resumoDeFluxoReservaBancaria.WriteLine(RetiradaReservaPara);
                        reserva.Retirada = 0;
                    }
                }

                using(StreamWriter resumoDeFluxoContaPoupanca = new StreamWriter("ResumoPoupança.txt",true))
                {
                    if (poupanca.Deposito > 0)
                    {
                        resumoDeFluxoContaPoupanca.WriteLine(depositoPoupancaPara);
                        poupanca.Deposito = 0;
                    }

                    if (poupanca.Retirada > 0)
                    {
                        resumoDeFluxoContaPoupanca.WriteLine(RetiradaPoupancaPara);
                        poupanca.Retirada = 0;
                    }
                }


                Console.WriteLine("Pressione Enter para exibir o Menu do Banco");
                Console.ReadLine();

                clinte.ExibirMenu();
                string EscolhaUsuario = Console.ReadLine();


                switch (EscolhaUsuario.ToUpper())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(clinte.InformarCliente());
                        break;
                    case "2A":
                        Console.Clear();
                        corrente.Balanco();
                        Console.WriteLine("Balanço de Conta Corrente: $" + corrente.Bal);
                        break;
                    case "2B":
                        Console.Clear();
                        Console.WriteLine("Balanço de Conta Poupança: $" + poupanca.Bal);
                        break;
                    case "2C":
                        Console.Clear();
                        reserva.Balanco();
                        Console.WriteLine("Balanço de ReservaBancária: $" + reserva.Bal);
                        break;
                    case "3A":
                        Console.Clear();
                        Console.WriteLine("Quanto você gostaria de depositar?");
                        corrente.Deposito = double.Parse(Console.ReadLine());
                        Console.WriteLine("Você depositou: $" + corrente.Deposito);
                        corrente.BalancoDeposito(corrente.Deposito);
                        break;
                    case "3B":
                        Console.Clear();
                        Console.WriteLine("Quanto você gostaria de depositar?");
                        reserva.Deposito = double.Parse(Console.ReadLine());
                        Console.WriteLine("Você depositou: $" + reserva.Deposito);
                        reserva.BalancoDeposito(reserva.Deposito);
                        break;
                    case "3C":
                        Console.Clear();
                        Console.WriteLine("Quanto você gostaria de depositar?");
                        poupanca.Deposito = double.Parse(Console.ReadLine());
                        Console.WriteLine("Você depositou: $" + poupanca.Deposito);
                        poupanca.BalancoDeposito(poupanca.Deposito);
                        break;
                    case "4A":
                        Console.Clear();
                        Console.WriteLine("Quanto você gostaria de retirar?");
                        corrente.Retirada = double.Parse(Console.ReadLine());
                        Console.WriteLine("Você retirou: $" + corrente.Retirada);
                        corrente.BalancoRetirado(corrente.Retirada);
                        break;
                    case "4B":
                        Console.Clear();
                        Console.WriteLine("Quanto você gostaria de retirar?");
                        reserva.Retirada = double.Parse(Console.ReadLine());
                        Console.WriteLine("Você retirou: $" + reserva.Retirada);
                        reserva.BalancoRetirado(reserva.Retirada);
                        break;
                    case "4C":
                        Console.Clear();
                        Console.WriteLine("Quanto você gostaria de retirar?");
                        poupanca.Retirada = double.Parse(Console.ReadLine());
                        Console.WriteLine("Você retirou: $" + poupanca.Retirada);
                        reserva.BalancoRetirado(poupanca.Retirada);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Você optou por sair do Banco online, Obrigado e volte sempre!!!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        teste = false;
                        break;
                }


            } while (!teste);

        }
    }

    

} 
