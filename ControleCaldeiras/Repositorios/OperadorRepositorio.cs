using ControleCaldeiras.Data;
using ControleCaldeiras.Models;
using ControleCaldeiras.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleCaldeiras.Repositorios
{
    public class OperadorRepositorio : IOperadorRepositorio
    {
        private readonly SistemaCaldeirasDBContex _dbContext;
        public OperadorRepositorio(SistemaCaldeirasDBContex sistemaCaldeirasDBContex)
        {
            _dbContext = sistemaCaldeirasDBContex;
        }   
        public async Task<OperadorModel> BuscarPorId(int id)
        {
            return await _dbContext.Operadores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<OperadorModel>> BuscarTodosOperadores()
        {
            return await _dbContext.Operadores.ToListAsync();
        }
        public async Task<OperadorModel> Adicionar(OperadorModel operador)
        {
           await _dbContext.Operadores.AddAsync(operador);
           await _dbContext.SaveChangesAsync();

            return operador;

        }
        public async Task<OperadorModel> Atualizar(OperadorModel operador, int id)
        {
           OperadorModel operadorPorId = await BuscarPorId(id);

            if(operadorPorId == null)
            {
                throw new Exception($"Operador para o ID:{id} não foi encontrado no banco de dados.");

            }

            operadorPorId.Nome = operador.Nome;

            _dbContext.Operadores.Update(operadorPorId);
            await _dbContext.SaveChangesAsync();

            return operadorPorId;
            
         
        }
        public async Task<bool> Apagar(int id)
        {
            OperadorModel operadorPorId = await BuscarPorId(id);

            if (operadorPorId == null)
            {
                throw new Exception($"Operador para o ID:{id} não foi encontrado no banco de dados.");

            }

            _dbContext.Operadores.Remove(operadorPorId);
           await  _dbContext.SaveChangesAsync();

            return true;
        }

       

       
    }
}
