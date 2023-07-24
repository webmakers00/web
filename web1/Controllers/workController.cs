using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using web1.ef;

namespace web1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("any")]
    public class workController:ControllerBase
    {
        [HttpGet(Name = "test")]
        public string Get()
        {
            using (MyDBcontext db = new MyDBcontext()) {
                Book book = new Book();
                book.Title = "test";
                db.Books.Add(book);
                db.SaveChanges();

            }
            return "test";
        }
    }
}
