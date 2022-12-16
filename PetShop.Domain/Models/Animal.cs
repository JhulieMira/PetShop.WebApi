using PetShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Domain.Models
{
    internal class Animal
    {
        public Cliente Tutor { get; set; }
        public string Nome { get; set; }
        public EspecieAnimal Especie { get; set; }
        public PorteAnimal PorteAnimal { get; set; }
        public string Raca { get; set; }
    }
}
