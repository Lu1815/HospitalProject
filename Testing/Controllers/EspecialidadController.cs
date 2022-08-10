using Microsoft.AspNetCore.Mvc;
using Testing.Models;

namespace Testing.Controllers
{
    public class EspecialidadController : Controller
    {
        protected readonly BDHospitalContext _db;

        public EspecialidadController(BDHospitalContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Especialidad> listaDeEspecialidades = _db.Especialidad
                .Where(especialidad => especialidad.Bhabilitado == 1)
                .ToList();
            return View(listaDeEspecialidades);
        }
    }
}
