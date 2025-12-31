using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Server_Manager___API.Controllers
{
    // The route template is "api/Delete/[ActionName]"
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeleteController : Controller
    {
        [HttpDelete("{id}")]
        [ActionName("CategoriesDeletor")]
        public IActionResult CategoriesDeletor(int id)
        {
            CategoriesDB categoriesDB = new CategoriesDB();
            categoriesDB.Delete(new Categories { Id = id });
            int changedRecords = categoriesDB.SaveChanges();

            if (changedRecords == 0) // Resource not found or already deleted
            {
                // Throw ExpandedException without SQL context. The middleware will catch this
                // and return a 404 Not Found (based on Case A logic in the handler).
                throw new Exception($"Not Found: Categories with idx = {id} was not found or has already been deleted.");
            }

            return StatusCode(200, $"OK: Record for Categories Idx=" +
                $"{id} was removed.\n Records changed: {changedRecords}");
        }
    }
}