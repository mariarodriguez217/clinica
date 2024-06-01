using _03_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion.DTOs
{
    public class PacienteDTO
    {
        IdP idp;
        NombreP nombrep;
        ApellidoP apellidop;
        FechaNacimiento fechanacimiento;

        public PacienteDTO(Guid idp, string nombrep, string apellidop, DateTime fechanacimiento)
        {
            this.idp = new IdP(idp);
            this.nombrep = new NombreP(nombrep);
            this.apellidop = ApellidoP(apellidop);
            this.fechanacimiento = new FechaNacimiento(fechanacimiento);

        }
        public Guid IdP()
        {
            return this.idp.Valor();
        }
        public string NombreP()
        {
            return this.nombrep.Valor();
        }
        public string ApellidoP()
        {
            return this.apellidop.Valor();
        }

        public DateTime FechaNacimiento()
        {
            return this.fechanacimiento.Valor();
        }

    }
}

}
