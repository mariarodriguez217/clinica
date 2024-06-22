using _02_Aplicacion.DTOs;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;

namespace _02_Aplicacion
{
    public class CrearPaciente
    {
        private PacienteRepositorio repositorio;

        public CrearPaciente(PacienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(PacienteDTO PacienteDTO)
        {
            this.repositorio.grabar(new Paciente(
                pacienteDTO.Idp(),
                pacienteDTO.Nombre(),
                pacienteDTO.Apellido(),
                pacienteDTO.FechaNacimiento()
            ));
        }
    }
}