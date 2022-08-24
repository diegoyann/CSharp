using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensaoUdemy
{
    class Cliente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Quarto { get; set; }

        public Cliente (string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Quarto
                + ": "
                + Nome
                + ", "
                + Email;
        }
    }
}
