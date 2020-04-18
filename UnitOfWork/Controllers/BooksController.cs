using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace UnitOfWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var result = await _unitOfWork.BookRepository.GetAsync();
            return Ok(result);
        }
    }
}