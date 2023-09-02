using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

    public class Persona :BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }

        /*LLAVES*/
        public ICollection<Matricula>Matriculas { get; set; }
        public ICollection<TrainerSalon> TrainerSalones { get; set; }
        
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersona { get; set; }

        public int IdGeneroFk { get; set; }
        public Genero Genero { get; set; }

        public int IdCiudadFk { get; set; }
        public Ciudad Ciudad { get; set; }
        /*LLAVES*/
    }
