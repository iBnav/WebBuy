using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool isValid
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
