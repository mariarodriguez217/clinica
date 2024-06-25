using Xunit;
using _03_Dominio.Entidades;
using System;

namespace Clinica.Tests.Dominio
{
    public class PacienteTests
    {
        [Fact]
        public void CrearPaciente_DeberiaAsignarValoresCorrectamente()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nombre = "Maria";
            var apellido = "Gomez";
            var fechaNacimiento = new DateTime(1995, 5, 10);

            // Act
            var paciente = new Paciente(id, nombre, apellido, fechaNacimiento);

            // Assert
            Assert.Equal(id, paciente.IdP());
            Assert.Equal(nombre, paciente.NombreP());
            Assert.Equal(apellido, paciente.ApellidoP());
            Assert.Equal(fechaNacimiento, paciente.FechaNacimiento());
        }

        [Fact]
        public void CrearPaciente_ConNombreInvalido_DeberiaLanzarArgumentException()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nombre = " "; // Nombre inválido
            var apellido = "Gomez";
            var fechaNacimiento = new DateTime(1995, 5, 10);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Paciente(id, nombre, apellido, fechaNacimiento));
        }

        [Fact]
        public void CrearPaciente_ConApellidoInvalido_DeberiaLanzarArgumentException()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nombre = "Maria";
            var apellido = ""; // Apellido inválido
            var fechaNacimiento = new DateTime(1995, 5, 10);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Paciente(id, nombre, apellido, fechaNacimiento));
        }

        [Fact]
        public void CrearPaciente_ConFechaNacimientoInvalida_DeberiaLanzarArgumentException()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nombre = "Maria";
            var apellido = "Gomez";
            var fechaNacimiento = DateTime.Now.AddYears(1); // Fecha de nacimiento en el futuro

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Paciente(id, nombre, apellido, fechaNacimiento));
        }
    }
}
