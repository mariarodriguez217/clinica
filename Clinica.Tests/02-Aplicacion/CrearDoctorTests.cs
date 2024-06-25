using Xunit;
using _02_Aplicacion;
using _02_Aplicacion.DTOs;
using Moq;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;
using System;

namespace Clinica.Tests.Aplicacion
{
    public class CrearDoctorTests
    {
        [Fact]
        public void CrearDoctor_DeberiaLlamarRepositorioGrabar()
        {
            // Arrange
            var mockRepositorio = new Mock<DoctorRepositorio>();
            var casoDeUso = new CrearDoctor(mockRepositorio.Object);
            var doctorDto = new DoctorDTO(Guid.NewGuid(), "Carlos", "Martinez", Especialidad.Oncologia, new DateTime(2020, 1, 1));

            // Act
            casoDeUso.Ejecutar(doctorDto);

            // Assert
            mockRepositorio.Verify(r => r.grabar(It.Is<Doctor>(
                d => d.IdD() == doctorDto.IdD()
                && d.Nombre() == doctorDto.Nombre()
                && d.Apellido() == doctorDto.Apellido()
                && d.FechaIngreso() == doctorDto.FechaIngreso())), Times.Once);
        }
    }
}
