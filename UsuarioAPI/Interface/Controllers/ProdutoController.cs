using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Produto.Service.ApplicationService;
using Produto.Common.DTO.ProdutoContext;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Produto.Interface.Controllers
{
    [Route("api/produto/")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoApplicationService _appService;

        public ProdutoController(ProdutoApplicationService appService)
        {
            _appService = appService;
        }

        [HttpGet("{id:int}")]
        public ProdutoDto getProduto(int id)
        {
            return _appService.GetById(id);
                        
        }

        [HttpGet("")]
        public List<ProdutoDto> ListarProdutos(int id)
        {
            return _appService.GetAll();
        }

        [HttpPost("")]
        public ActionResult Insert(ProdutoDto dto, int idUsuario)
        {
            _appService.Insert(dto);
            return Ok();
        }

        [HttpPut("{id:int}")]
        public ActionResult Update(ProdutoDto dto, int id)
        {
            _appService.Update(dto, id);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete( int id)
        {
            _appService.Delete( id);
            return Ok();
        }
    }
}