using Xunit;
using _02_Aplicacion;
using _02_Aplicacion.DTOs;
using Moq;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;
using System;

namespace Clinica.Tests.Aplicacion
{
    public class CrearPacienteTests
    {
        [Fact]
        public void CrearPaciente_DeberiaLlamarRepositorioGrabar()
        {
            // Arrange
            var mockRepositorio = new Mock<PacienteRepositorio>();
            var casoDeUso = new CrearPaciente(mockRepositorio.Object);
            var pacienteDto = new PacienteDTO(Guid.NewGuid(), "Maria", "Gomez", new DateTime(1995, 5, 10));

            // Act
            casoDeUso.Ejecutar(pacienteDto);

            // Assert
            mockRepositorio.Verify(r => r.grabar(It.Is<Paciente>(
                p => p.IdP() == pacienteDto.IdP()
                && p.Nombre() == pacienteDto.NombreP()
                && p.Apellido() == pacienteDto.ApellidoP()
                && p.FechaNacimiento() == pacienteDto.FechaNacimiento())), Times.Once);
        }
    }
}
