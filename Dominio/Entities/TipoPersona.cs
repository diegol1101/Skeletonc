using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

    public class TipoPersona : BaseEntity
    {
        public string Descripcion { get; set; }

        /*LLAVES*/
        public ICollection<Persona> Personas { get; set; }
        
        /*LLAVES*/
    }