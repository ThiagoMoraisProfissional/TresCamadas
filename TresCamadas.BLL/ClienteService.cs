using TresCamadas.DAL.Repositories;
using TresCamadas.Model.Models;

namespace TresCamadas.BLL
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;
        public ClienteService(ClienteRepository repository)
        {
            _clienteRepository = repository;
        }

        public bool CadastrarCliente(ClienteModel cliente)
        {
            //Fazer a chamada na DAL
            var result = _clienteRepository.Cadastrar(cliente);
            return result;
        }

        public List<ClienteModel> ObterTodosClientes()
        {
            //Fazer chamada na DAL
            var listaCliente = _clienteRepository.ObterTodos();
            return listaCliente;
        }

        public ClienteModel? ObterClientePorId(long paramId)
        {
            var cliente = _clienteRepository.ObterPorId(paramId);
            return cliente;
        }


    }
}
