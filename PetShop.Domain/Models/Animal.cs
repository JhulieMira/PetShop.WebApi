using PetShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Domain.Models
{
    public class Animal : Entity
    {
        public Cliente Tutor { get; set; }
        public string Nome { get; set; }
        public EspecieAnimal Especie { get; set; }
        public PorteAnimal PorteAnimal { get; set; }
        public string Raca { get; set; }
    }
}
