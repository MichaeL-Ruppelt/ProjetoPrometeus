using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPrometeus
{
    public class EnderecoModel
    {
        public string Rua {  get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
    }
}
