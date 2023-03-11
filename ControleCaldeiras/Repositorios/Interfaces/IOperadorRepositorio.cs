using ControleCaldeiras.Models;

namespace ControleCaldeiras.Repositorios.Interfaces
{
    public interface IOperadorRepositorio
    {
        Task<List<OperadorModel>> BuscarTodosOperadores();
        Task<OperadorModel> BuscarPorId(int id);
        Task<OperadorModel> Adicionar(OperadorModel operador);
        Task<OperadorModel> Atualizar(OperadorModel operador,int id);
        Task<bool> Apagar(int id);

    }
}
