using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPrometeus
{
    public class ClienteModel
    {
        public string Nome { get; set;}
        public string CPF { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public int idade { get; set; }
        public EnderecoModel Endereco { get; set; }

        public ClienteModel()
        {
            Endereco = new EnderecoModel();
        }
    }
}
