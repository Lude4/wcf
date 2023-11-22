using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS_Wcf.modelo
{
    public class Controle
    {
        public String mensagem;

        public String executar(String numero)
        {
            this mensagem = "";

            Validacao validacao = new Validacao();
            validacao.validar(numero);

            if (validacao.mensagem.Equals(""))
            {
                Negocio negocio = new Negocio();
                this.mensagem = negocio.onibuslinhanumero(validacao.valorformatado);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}