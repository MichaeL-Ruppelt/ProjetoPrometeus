using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjetoPrometeus
{
    public class ConsoleFrontEndService
    {
        public CadastrarClientesService cadastro;
        public ConsoleFrontEndService()
        {
            cadastro = new CadastrarClientesService();
        }

        public void GerarTelaInicial()
        {
            while (true) { 
            Console.WriteLine("Olá BEM VINDO, ao sistema X");
            Console.WriteLine("Seleciona a Opção abaixo");
            Console.WriteLine("digite 1 - Para Consultar associados");
            Console.WriteLine("digite 2 - Para Deletar associados");
            Console.WriteLine("digite 3 - Para Atualizar associados");
            Console.WriteLine("digite 4 - Para Inserir associados");

            string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        GeraTelaCosultar();
                        break;
                    case "2":
                        GeraTelaDeletar();
                        break;
                    //case "3":
                    //    GeraTelaAtualizar();
                    //    break;
                    case "4":
                        GeraTelaInserir();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, Tente Novamente");
                        break;
                }
            }
        }

        private void GeraTelaDeletar()
        {
            Console.WriteLine("Escreva o CPF do CLiente a ser deletado");
            string cpf = Console.ReadLine();

            cadastro.Remover(cpf);
            Console.WriteLine($"Cliente {cpf} removido");
        }

        private void GeraTelaInserir()
        {
            ClienteModel novoCliente = new ClienteModel();
            Console.WriteLine("Escreva o Nome do CLiente");
            novoCliente.Nome = Console.ReadLine();
            Console.WriteLine("Escreva o Cpf do CLiente");
            novoCliente.CPF = Console.ReadLine();
            Console.WriteLine("Escreva o Telefone do CLiente");
            novoCliente.Telefone = Int32.Parse(Console.ReadLine());

            cadastro.Inserir(novoCliente);
        }

        private void GeraTelaCosultar()
        {
            Console.WriteLine("Insira o CPF do cliente");
            string cpf = Console.ReadLine();
            var cliente = cadastro.ConsultarCPF(cpf);
            if(cliente is null)
                Console.WriteLine($"Esse CLiente não existe");
            else
                Console.WriteLine($"{cliente.Nome} - {cliente.CPF}");
        }

        public void ConsultarClientes()
        { 
        
        }
    }
}
