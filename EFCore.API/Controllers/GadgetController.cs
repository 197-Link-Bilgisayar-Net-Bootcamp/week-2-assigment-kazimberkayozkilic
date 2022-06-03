using System.Linq;
using System.Threading.Tasks;
using EFCore.API.DataAccess;
using EFCore.API.DataAccess.Entities;
using EFCore.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dotnet5.API.CRUD.EF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GadgetsController : ControllerBase
    {
        private readonly MyDbContext _db;
        public GadgetsController(MyDbContext myWorldDbContext)
        {
            _db = myWorldDbContext;
        }

        [HttpGet]
        public IActionResult GetAllGadtets()
        {
            var allGadgets = _db.Gadgets.ToList();
            return Ok(allGadgets);
        }

        [HttpPost]
        public IActionResult CreateGadget(Gadget gadgets)
        {
            _db.Gadgets.Add(gadgets);
            _db.SaveChanges();
            return Ok(gadgets.Id);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateGadget(int id, GadgetModel model)
        {
            Gadget gadget = _db.Gadgets.Find(id);
            if (gadget == null) return NotFound();

            string gadgetName = model.ProductName?.Trim().ToLower();
            if (_db.Gadgets.Any(x => x.ProductName.ToLower() == gadgetName && x.Id != id))
            {
                return BadRequest();
            }

            gadget.ProductName = model.ProductName;
            gadget.Brand = model.Brand;
            gadget.Cost = model.Cost;
            gadget.Type = model.Type;

            _db.SaveChanges();
            GadgetModel data = new GadgetModel
            {
               ProductName = gadget.ProductName,
                Brand = gadget.Brand,
                Cost = gadget.Cost,
                Type = gadget.Type

            };
           

            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGadget(int id)
        {
            var gadgetToDelete = _db.Gadgets.Where(x => x.Id == id).FirstOrDefault();
            if (gadgetToDelete == null)
            {
                return NotFound();
            }

            _db.Gadgets.Remove(gadgetToDelete);
            _db.SaveChanges();
            return NoContent();
        }
    }
}