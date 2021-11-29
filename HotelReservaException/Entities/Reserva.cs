using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
