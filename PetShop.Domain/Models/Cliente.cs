using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Domain.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string NumeroCelular { get; set; }
        public string Email { get; set; }
        public List<string> Animais { get; set; }
    }
}
