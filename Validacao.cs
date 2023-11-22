using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS_Wcf.modelo
{
    public class Validacao
    {
        public int valorformatado;
        public String mensagem;
        public String validar(String valor)
        {
            this mensagem = "";

            try
            {
                this.valorformatado = Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                this.mensagem = "Número invalido"
            }

            return mensagem;
        }
    }
}