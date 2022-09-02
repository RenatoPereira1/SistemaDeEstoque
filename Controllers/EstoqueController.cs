using Microsoft.AspNetCore.Mvc;
using Estoque.Models;
 
namespace Estoque.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EstoquerController : ControllerBase
    {
        private BDContexto contexto;
 
        public EstoquerController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }
 
        [HttpGet]
        public List<Estoquer> Listar()
        {
            return contexto.Estoques.ToList();
        }
 

    }
}