using System;
using HotelReservaException.Exceptions;
using HotelReservaException.Entities;

namespace HotelReservaException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o numero do Quarto:  ");
                int quarto = int.Parse(Console.ReadLine());

                Console.Write("Digite o data de Entrada (dd/MM/yyyy) ");
                DateTime dataE = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite o data de Saida (dd/MM/yyyy) ");
                DateTime dataS = DateTime.Parse(Console.ReadLine());


                Reserva reserva = new Reserva(quarto, dataE, dataS);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Entre com os dados para Atuaizar");

                Console.Write("Digite o data de Entrada (dd/MM/yyyy) ");
                dataE = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite o data de Saida (dd/MM/yyyy) ");
                dataS = DateTime.Parse(Console.ReadLine());

                reserva.updateReserva(dataE, dataS);

                Console.WriteLine("Nova reserva: " + reserva);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato: " + e.Message);
            }


        }
    }


}






