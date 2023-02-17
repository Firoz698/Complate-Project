using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationOne.DatabaseContext;
using WebApplicationOne.Models;

namespace WebApplicationOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationOneController : ControllerBase
    {

        DataBaseUsm _db;
        List<Post> _posts=new List<Post>();
        public ApplicationOneController(DataBaseUsm db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Post> GetAllPost()
        {
            _posts= _db.posts.ToList();
            return _posts;
        }



    }
}
