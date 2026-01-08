using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        [HttpPost]
        [ActionName("InsertAUser")]
        public int InsertUser(Users user)
        {
            UsersDB usersDB = new UsersDB();
            usersDB.Insert(user);
            return usersDB.SaveChanges();
        }


    }
}
