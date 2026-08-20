using System;
namespace Atividade05;

internal class Program
{
  static void Main(string[] args)
  {
    Hospede renato = new Hospede();
    Reserva reservaRenato = new Reserva();
    renato.ReceberDados();
    renato.AtualizarTelefone("34999370548");
    renato.MostrarDados();
    reservaRenato.ReceberDados();
    reservaRenato.CalcularTotal();
    reservaRenato.AplicarDesconto(10);
    reservaRenato.MostrarReserva();
  }
}