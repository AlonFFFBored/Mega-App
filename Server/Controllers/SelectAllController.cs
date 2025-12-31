using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Server_Manager___API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectAllController : Controller
    {
        [HttpGet]
        [ActionName("SelectAllCategories")]
        public Categories_List SelectAllCategories()
        {
            CategoriesDB categoriesDB = new CategoriesDB();
            Categories_List categoriesTable = categoriesDB.SelectAll();
            return categoriesTable;
        }


    }
}
