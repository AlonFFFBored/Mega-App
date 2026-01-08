using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        [HttpPut]
        [ActionName("UpdateAUser")]
        public int UpdateUser(Users user)
        {
            UsersDB usersDB = new UsersDB();
            usersDB.Update(user);
            return usersDB.SaveChanges();
        }


    }
}
