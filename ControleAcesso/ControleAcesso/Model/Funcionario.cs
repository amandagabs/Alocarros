using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Model
{
    class Funcionario
    {
        public int FuncionarioID { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Nasc { get; set; }

        public string Telefone { get; set; }

        public string Empresa { get; set; }

        public string Horario { get; set; }

        public bool Ativo { get; set; }
    }
}
