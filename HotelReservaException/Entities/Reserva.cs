using System;
using HotelReservaException.Exceptions;

namespace HotelReservaException.Entities
{
    class Reserva
    {

        public int Quarto { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public Reserva() { }

        public Reserva(int quarto, DateTime entrada, DateTime saida)
        {

            if (entrada < DateTime.Now)
            {
                throw new DomainException("Erro na reserva. Entrada não pode ser inferior a data de hoje !");

            }
            else if (entrada > saida)
            {
                throw new DomainException("Erro na reserva. Saida não pode ser inferior a data de Entrada !");

            }

            Quarto = quarto;
            Entrada = entrada;
            Saida = saida;
        }

        public int Duracao()
        {
            TimeSpan duracao = Saida.Subtract(Entrada);

            return (int)duracao.TotalDays; // retorna um double


        }

        public void updateReserva(DateTime entrada, DateTime saida)
        {
            DateTime hoje = DateTime.Now;

            if (entrada < hoje || saida < hoje)
            {
                throw new DomainException("Erro na reserva: Datas foram do padrão");
            }
            else if (entrada > saida || saida < entrada)
            {
                throw new DomainException("Erro na reserva. Saida não pode ser inferior a data de Entrada !");

            }
            else
            {


            }
            Entrada = entrada;
            Saida = saida;
        }

        public override string ToString()
        {

            return "Quarto: "
                + Quarto
                + " Entrada: "
                + Entrada.ToString("dd/MM/yyyy")
                + " Saida: "
                + Saida.ToString("dd/MM/yyyy")
                + " Duração: "
                + Duracao()
                + " Noites ";
        }
    }
}

