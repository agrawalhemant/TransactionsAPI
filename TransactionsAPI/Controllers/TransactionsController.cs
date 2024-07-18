using Microsoft.AspNetCore.Mvc;
using TransactionsAPI.DAL;
using TransactionsAPI.DataModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TransactionsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private TransactionDbContext _context;
        public TransactionsController(TransactionDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Produces(typeof(List<Transaction>))]
        public IActionResult Get()
        {
            try
            {
                var res = _context.Transaction.ToList();
                return Ok(res);
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var res = _context.Transaction.Where(x => x.tid == id).FirstOrDefault();
            return Ok(res);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Transaction transaction)
        {
            _context.Transaction.Add(transaction);
            _context.SaveChanges();
            return Ok("transaction is saved");
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
