using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Testing.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            Doctors = new HashSet<Doctor>();
        }

        [Display(Name = "Id Especialidad")]
        public int Iidespecialidad { get; set; }
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }
        [Display(Name = "Descripcion")]
        public string? Descripcion { get; set; }
        [Display(Name = "BHabilitado")]
        public int? Bhabilitado { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
