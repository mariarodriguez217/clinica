using _02_Aplicacion.DTOs;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion
{
    public class ListarPacientes
    {
        private PacienteRepositorio repositorio;

        public ListarPacientes(PacienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<PacienteDTO> Ejecutar()
        {
            List<PacienteDTO> PacienteesDTO = new List<PacienteDTO>();
            List<Paciente> paciente = this.repositorio.listar();
            foreach (Paciente paciente in pacientes)
            {
                PacienteDTO pacienteDTO = new PacienteDTO(
                    paciente.IdP(),
                    paciente.Nombre(),
                    paciente.FechaNaciemiento()
                );
                pacientesDTO.Add(pacienteDTO);
            }
            return pacientesDTO;
        }
    }
}