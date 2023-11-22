using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS_Wcf.modelo
{
    public class Negocio
    {

        public String onibuslinhanumero(int numero)
        {
            String resposta =

            switch (numero)
            {
                case "48":
                    Console.WriteLine("Bairro: Amato/Monteiro");
                    Console.WriteLine("Terminal: Terminal");
                    Console.WriteLine("Horários Bairro: 04:05/08:10/16:10/19:55");
                    Console.WriteLine("Horários Terminal: 04:25/07:50/15:50/19:25");
                    break;

                case "14":
                    Console.WriteLine("Bairro: Santa Rosália");
                    Console.WriteLine("Terminal: Santo Antonio");
                    Console.WriteLine("Horários Bairro: 04:30/11:55/12:18/23:10");
                    Console.WriteLine("Horários Terminal: 05:00/11:44/12:07/23:45");
                    break;

                case "44":
                    Console.WriteLine("Bairro: Novo Mundo");
                    Console.WriteLine("Terminal: Santo Antonio");
                    Console.WriteLine("Horários Bairro: 04:30/11:38/12:08/23:25");
                    Console.WriteLine("Horários Terminal: 00:10/11:52/12:22/23:29");
                    break;

                case "56":
                    Console.WriteLine("Bairro: Iguatemi");
                    Console.WriteLine("Terminal: São Paulo");
                    Console.WriteLine("Horários Bairro: 06:15/10:50/12:30/23:10");
                    Console.WriteLine("Horários Terminal: 05:30/11:35/13:10/23:50");
                    break;

                case "65":
                    Console.WriteLine("Bairro: Campolim ");
                    Console.WriteLine("Terminal: Santo Antonio");
                    Console.WriteLine("Horários Bairro: 00:05/12:00/12:12/23:48");
                    Console.WriteLine("Horários Terminal: 00:10/12:00/12:12/23:32");
                    break;

                case "76":
                    Console.WriteLine("Bairro: São Guilherme");
                    Console.WriteLine("Terminal: Santo Antonio");
                    Console.WriteLine("Horários Bairro: 04:15/12:00/12:30/23:30");
                    Console.WriteLine("Horários Terminal: 00:00/12:00/12:30/23:00");
                    break;

                case "100":
                    Console.WriteLine("Bairro: Expresso");
                    Console.WriteLine("Terminal: Santo Antonio");
                    Console.WriteLine("Horários Bairro: 04:30/11:56/12:10/23:40");
                    Console.WriteLine("Horários Terminal: 04:40/12:00/12:06/23:50");
                    break;

                case "101":
                    Console.WriteLine("Bairro: Rodoviária / Pça. Nove de Julho");
                    Console.WriteLine("Terminal: Santo Antonio");
                    Console.WriteLine("Horários Bairro: 04:45/11:54/12:18/23:40");
                    Console.WriteLine("Horários Terminal: 04:30/11:50/12:14/23:20");
                    break;

                case "120":
                    Console.WriteLine("Bairro: Paineiras");
                    Console.WriteLine("Terminal: Sto. Antonio/Est. Itavuvu");
                    Console.WriteLine("Horários Bairro: 16:00/12:00/12:20/23:50");
                    Console.WriteLine("Horários Terminal: 00:20/11:45/12:05/23:50");
                    break;

                case "160":
                    Console.WriteLine("Bairro: São Bento");
                    Console.WriteLine("Terminal: Santo Antonio");
                    Console.WriteLine("Horários Bairro: 04:00/12:00/12:20/23:40");
                    Console.WriteLine("Horários Terminal: 00:00/12:00/12:20/23:40");
                    break;

                default:
                    Console.WriteLine("Número de ônibus inválido");
                    break;

            }

            return resposta;
        }
    }
}