using System.Globalization;


namespace DesafioProjetoHospedagem.Models;
public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() 
    {
        Hospedes = new List<Pessoa>(); // Inicializa a lista de hóspedes
    }

    public Reserva(int diasReservados) : this() // Garante que a lista seja inicializada
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        // Garante que a lista de hóspedes não será null
        if (Hospedes == null)
        {
            Hospedes = new List<Pessoa>();
        }

        // Verifica se a quantidade de hóspedes não excede a capacidade da suíte
        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes; // Adiciona os hóspedes
        }
        else
        {
            Hospedes = hospedes;
            // Exibe a mensagem de erro, mas não lança exceção
            Console.WriteLine("Número de hóspedes excede a capacidade da suíte.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        // Retorna a quantidade de hóspedes
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        // Desconto caso reserve mais de 10 dias
        if (DiasReservados >= 10)
        {
            Console.WriteLine("Desconto aplicado");
            valor = valor * 0.9M;
        }

        return valor;
    }
}