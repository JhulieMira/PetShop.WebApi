using PetShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Domain.Interfaces
{
    public interface IAnimalService
    {
        Task<Animal> Adicionar(Animal animal);
        Task<Animal> Atualizar(Animal animal);
        Task Remover(Guid id);
    }
}
