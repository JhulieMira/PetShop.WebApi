using PetShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Domain.Models;

namespace PetShop.Domain.Notificacao
{
    public class Notificador : INotificador
    {
        private List<Models.Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Models.Notificacao>();
        }

        public void Handle(Models.Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }

        List<Models.Notificacao> INotificador.ObterNotificacoes()
        {
            throw new NotImplementedException();
        }
    }
}
