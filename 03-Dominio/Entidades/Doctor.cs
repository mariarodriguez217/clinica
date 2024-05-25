using System;
using _03_Dominio.ValueObjects;

namespace _03_Dominio.Entidades
{
    public class Doctor
    {
        IdD idd;
        Nombre nombre;
        Apellido apellido;
        Especialidad especialidad;
        FechaIngreso fechaingreso;
        
        public Doctor (Guid idd, string nombre,string apellido,Especilidad especialidad,DateTime fechaingreso )
        {
            this.idd = new Id(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.especialidad = especialidad;
            this.fechaingreso = new FechaIngreso(fechaingreso);
        }
        public Guid idd()
        {
            return this.idd.Valor();
        }
        public string Nombre()
        {
            return this.nombre.Valor();
        }
        public string Apellido()
        {
            return this.apellido.Valor();
        }
        public string Especialidad()
        {
            return this.especialidad.Valor();
        }
        public DateTime FechaIngreso()
        {
            return this.fechaingreso.Valor();
        }






    }
}
