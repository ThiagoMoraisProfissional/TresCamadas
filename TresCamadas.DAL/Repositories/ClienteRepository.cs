using TresCamadas.DAL.Context;
using TresCamadas.Model.Models;

namespace TresCamadas.DAL.Repositories
{
    public class ClienteRepository
    {
        private readonly TresCamadasContext _context;
        public ClienteRepository(TresCamadasContext context)
        {
            _context = context;
        }

        public bool Cadastrar(ClienteModel cliente) 
        {
            _context.Add(cliente);
            return _context.SaveChanges() > 0;
        }

        public List<ClienteModel> ObterTodos()
        {
            var lista = _context.Clientes.ToList();
            return lista;
        }

        public ClienteModel? ObterPorId(long paramId)
        {
            var cliente = _context.Clientes.Where(x => x.Id == paramId).FirstOrDefault();
            return cliente;
        }
    }
}
