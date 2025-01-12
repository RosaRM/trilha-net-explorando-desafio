using System.Globalization;


namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("Número de hóspedes excede a capacidade da suíte.");
            
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorDiaria;;


            if (DiasReservados >= 10)
            {
                valor = valor * 0.9M;
            }

            return valor;
        }
    }
}