using _02_Aplicacion.DTOs;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;

namespace _02_Aplicacion
{
    public class CrearDoctor
    {
        private DoctorRepositorio repositorio;

        public CrearDoctor(DoctorRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(DoctorDTO DoctorDTO)
        {
            this.repositorio.grabar(new Doctor(
                doctorDTO.Idd(),
                doctosDTO.Nombre(),
                doctorDTO.Apellido(),
                doctorDTO.FechaIngreso()
            ));
        }
    }
}