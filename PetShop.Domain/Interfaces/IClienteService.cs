using PetShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Domain.Interfaces
{
    public interface IClienteService
    {
        Task Adicionar(Cliente cliente);
        Task Editar(Cliente cliente);
        Task Excluir(Cliente cliente);
    }
}
