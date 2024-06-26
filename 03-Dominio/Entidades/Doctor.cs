﻿using System;
using _03_Dominio.ValuesObject;

namespace _03_Dominio.Entidades
{
    public class Doctor
    {
        IdD idd;
        Nombre nombre;
        Apellido apellido;
        FechaIngreso fechaingreso;
        
        public Doctor (Guid idd, string nombre,string apellido,DateTime fechaingreso )
        {
            this.idd = new Id(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
   
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
      
        public DateTime FechaIngreso()
        {
            return this.fechaingreso.Valor();
        }






    }
}
