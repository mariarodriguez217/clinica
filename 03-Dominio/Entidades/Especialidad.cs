using System;
using _03_Dominio.ValueObjects;
namespace _03_Dominio.Entidades
{
    public class Especialidad
    {
        IdE ide;
        NombreE nombree;

        public Especialidad(Guid ide, string nombree)
        {
            this.idp = new IdP(idp);
            this.nombree = new NombreE(nombree);

        }
        public Guid IdE()
        {
            return this.ide.Valor();
        }
        public string NombreE()
        {
            return this.nombree.Valor();
        }

    }
}

}
