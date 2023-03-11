using ControleCaldeiras.Models;
using ControleCaldeiras.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleCaldeiras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperadorController : ControllerBase
    {
        private readonly IOperadorRepositorio _operadorRepositorio;

        public OperadorController(IOperadorRepositorio operadorRepositorio)
        {
            _operadorRepositorio = operadorRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<OperadorModel>>> BuscarTodosOperadores()
        {
            List<OperadorModel> operador = await _operadorRepositorio.BuscarTodosOperadores();
            return Ok(operador);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OperadorModel>> BuscarPorId(int id)
        {
            OperadorModel operador = await _operadorRepositorio.BuscarPorId(id);
            return Ok(operador);
        }

        [HttpPost]
        public async Task<ActionResult<OperadorModel>> Cadastrar([FromBody]OperadorModel operadorModel)
        {
            OperadorModel operador = await _operadorRepositorio.Adicionar(operadorModel);

            return Ok(operador);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<OperadorModel>> Atualizar([FromBody] OperadorModel operadorModel,int id)
        {
            operadorModel.Id = id;
            OperadorModel operador = await _operadorRepositorio.Atualizar(operadorModel,id);

            return Ok(operador);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OperadorModel>> Apagar( int id)
        {
        
            bool apagado = await _operadorRepositorio.Apagar( id);

            return Ok(apagado);
        }
    }
}
