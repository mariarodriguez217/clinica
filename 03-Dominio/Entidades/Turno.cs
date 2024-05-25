using System;
using _03_Dominio.ValueObjects;
namespace _03_Dominio.Entidades
{
    public class Turno
    {
        IdT idt;
        Paciente paciente
        Doctor doctor;
        Especialidad especialidad;
        FechaTurno fechaturno;

        public Turno(Guid idt, Paciente paciente, Doctor doctor, Especialidad especialidad, DateTime fechaturno)
        {
            this.idt = new IdT(idt);
            this.paciente = paciente;
            this.doctor = doctor;
            this.especialidad = especialidad;
            this.fechaturno = new FechaTurno(fechaturno);

        }
        public Guid Idt()
        {
            return this.idt.Valor();
        }
        public Paciente Paciente()
        {
            return this.paciente.Valor();
        }
        public Doctor Doctor()
        {
            return this.doctor.Valor();
        }

        public Especilidad Especialidad()
        {
            return this.especialidad.Valor();
        }
        public DateTime FechaTurno()
        {
            return this.fechaturno.Valor();
        }

    }
}

