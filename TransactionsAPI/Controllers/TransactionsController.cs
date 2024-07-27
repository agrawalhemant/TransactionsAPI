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

        /// <summary>
        /// Get all transactions of all profiles
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Get transaction details
        /// </summary>
        /// <param name="transactionId">transactionId</param>
        /// <returns></returns>
        [HttpGet("{profileId}")]
        public ActionResult GetDetails()
        {
            int transactionId = 0;
            var res = _context.Transaction.Where(x => x.tid == transactionId).FirstOrDefault();
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
