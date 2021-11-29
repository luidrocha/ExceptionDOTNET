using System;
using System;
using ReservaHotelException.Entities;
namespace ReservaHotelException

namespace HotelReservaException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero do Quarto:  ");
            int quarto = int.Parse(Console.ReadLine());

            Console.Write("Digite o data de Entrada (dd/MM/yyyy) ");
            DateTime dataE = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite o data de Saida (dd/MM/yyyy) ");
            DateTime dataS = DateTime.Parse(Console.ReadLine());

            if (dataE < DateTime.Now)
            {
                Console.WriteLine("Erro na reserva. Entrada não pode ser inferior a data de hoje !");

            }
            else if (dataE > dataS)
            {
                Console.WriteLine("Erro na reserva. Saida não pode ser inferior a data de Entrada !");

            }
            else
            {

                Reserva reserva = new Reserva(quarto, dataE, dataS);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Entre com os dados para Atuaizar");

                Console.Write("Digite o data de Entrada (dd/MM/yyyy) ");
                dataE = DateTime.Parse(Console.ReadLine());

                Console.Write("Digite o data de Saida (dd/MM/yyyy) ");
                dataS = DateTime.Parse(Console.ReadLine());

                DateTime hoje = DateTime.Now;

                if (dataE < hoje || dataS < hoje)
                {
                    Console.WriteLine("Erro na reserva: Datas foram do padrão");
                }
                else if (dataE > dataS || dataS < dataE)
                {
                    Console.WriteLine("Erro na reserva. Saida não pode ser inferior a data de Entrada !");

                }
                else
                {

                    reserva.updateReserva(dataE, dataS);

                    Console.WriteLine("Nova reserva: " + reserva);
                }



            }




        }
    }
}
