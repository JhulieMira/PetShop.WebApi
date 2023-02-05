using PetShop.Domain.Notificacao;

namespace PetShop.Domain.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Models.Notificacao> ObterNotificacoes();
        void Handle(Models.Notificacao notificacao);
    }
}
