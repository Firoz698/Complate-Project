using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using WebApplicationOne.DatabaseContext;
using WebApplicationOne.Models;

namespace WebApplicationOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManageMentController : ControllerBase
    {
        DataBaseUsm _db;
        public UserManageMentController(DataBaseUsm db )
        {
             _db=db;
        }


        [HttpGet]
        [Route ("Users")]
        public List<User> UserReturn()
        {
            List<User> data = new List<User>();
            data=_db.User.ToList();
            return data;
        }


        [HttpGet]
        [Route ("SingleGet")]
        public User SingleGet(int Id)
        {
            User user = new User();
            user = _db.User.Find(Id);
            return user;
        }



        [HttpPost]
        [Route ("UserPost")]
        public User UserPost(User oUser)
        {
            _db.User.Add(oUser);
            _db.SaveChanges();
            return oUser;
        }



        [HttpPost]
        [Route ("UserPut")]
        public User UserPut(User Obj)
        {


            if (Obj.Id==0)
            {
                User obj = new User();
                return obj;
            }else
            {
                User ojnNew = new User();
                ojnNew= _db.User.Find(Obj.Id);
                if (ojnNew==null)
                {
                    ojnNew = new User();
                    return ojnNew;
                }
                _db.User.Update(Obj);
                _db.SaveChanges();

            }
         
            return Obj;
        }



        [HttpDelete]
        [Route ("UserDeleted")]
        public User UserDeleted(int Id)
        {
            User user = new User();
            user=_db.User.Find(Id);
            
            _db.User.Remove(user);
            _db.SaveChanges ();
            return user;

        }



    }
}
