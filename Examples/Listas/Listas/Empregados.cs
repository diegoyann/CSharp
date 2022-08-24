using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Empregados
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregados(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentarSaiario (double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }
        public override string ToString()
        {
            return ID
                + ", "
                + Nome
                + ", "
                + Salario;
        }

    }
}
