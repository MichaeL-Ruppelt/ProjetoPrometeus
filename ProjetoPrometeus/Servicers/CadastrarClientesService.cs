using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPrometeus
{
    public class CadastrarClientesService
    {
        public List<ClienteModel> Clientes { get; set; }

        public CadastrarClientesService()
        {
            Clientes = new List<ClienteModel>();
        }

        public bool Inserir(ClienteModel novoCliente)
        {
            if (novoCliente is null)
                return false;
            
            Clientes.Add(novoCliente);

            return true;
        }

        public ClienteModel ConsultarCPF( string cpf)
        {
            return Clientes.Where(cliente => cliente.CPF == cpf).FirstOrDefault();
        }

        public ClienteModel ConsultarNome(string nome)
        {
            return Clientes.Where(cliente => cliente.Nome == nome).FirstOrDefault();
        }

        public ClienteModel Atualizar(ClienteModel clienteAtualizar)
        {
            var clienteDesatualizado = ConsultarCPF(clienteAtualizar.CPF);
            Clientes.Remove(clienteDesatualizado);
            Inserir(clienteAtualizar);

            return clienteAtualizar;
        }

        public List<ClienteModel> ConsultarLista()
        {
            return Clientes;
        }

        public void Remover(string cpf)
        {
            var clienteRemover = ConsultarCPF(cpf);
            Clientes.Remove(clienteRemover);
        }

        public void Excluir(string cpf)
        {
            var clienteRemover = ConsultarCPF(cpf);
            Clientes.Remove(clienteRemover);
        }


    }



}
