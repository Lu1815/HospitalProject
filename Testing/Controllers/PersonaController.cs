using Microsoft.AspNetCore.Mvc;
using Testing.Models;
using Testing.Models.Clases;

namespace Testing.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            List<PersonaCLS> personasList = new List<PersonaCLS>();
            using (BDHospitalContext _db = new BDHospitalContext())
            {
                personasList = _db.Personas
                    .Join(
                        _db.Sexos,
                        persona => persona.Iidsexo,
                        sexo => sexo.Iidsexo,
                        (persona, sexo) => new PersonaCLS(){
                            iidPersona = persona.Iidpersona,
                            nombreCompleto = persona.Nombre + " " + persona.Appaterno + " " + persona.Apmaterno,
                            email = persona.Email,
                            nombreSexo = sexo.Nombre
                    }).ToList();
            }
            return View(personasList);
        }
    }
}
