using System;
using _03_Dominio.ValueObjects;
namespace _03_Dominio.Entidades
{
    public class Paciente
    {
        IdP idp;
        NombreP nombrep;
        ApellidoP apellidop;
        FechaNacimiento fechanacimiento;

        public Paciente(Guid idp, string nombrep, string apellidop, DateTime fechanacimiento)
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
        public string ApellidoP ()
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
