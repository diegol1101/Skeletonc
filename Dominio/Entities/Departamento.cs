using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

    public class Departamento : BaseEntity
    {
        public string NombreDepeartamento { get; set; }

        /*LLAVES*/

        public int IdPaisFk { get; set; }
        public Pais Pais { get; set; }
        public ICollection<Ciudad> Ciudades { get; set;}

        /*LLAVES*/
    }
