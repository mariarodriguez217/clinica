using Xunit;
using _03_Dominio.Entidades;
using System;
using System.Numerics;

namespace Clinica.Tests.Dominio
{
    public class DoctorTests
    {
        [Fact]
        public void CrearDoctor_DeberiaAsignarValoresCorrectamente()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nombre = "Juan";
            var apellido = "Perez";
            var fechaIngreso = new DateTime(2023, 1, 1);

            // Act
            var doctor = new Doctor(id, nombre, apellido, fechaIngreso);

            // Assert
            Assert.Equal(id, doctor.IdD());
            Assert.Equal(nombre, doctor.Nombre());
            Assert.Equal(apellido, doctor.Apellido());
            Assert.Equal(fechaIngreso, doctor.FechaIngreso());
        }

        [Fact]
        public void CrearDoctor_ConNombreInvalido_DeberiaLanzarArgumentException()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nombre = " "; // Nombre inválido
            var apellido = "Perez";
            var fechaIngreso = new DateTime(2023, 1, 1);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Doctor(id, nombre, apellido, fechaIngreso));
        }

        [Fact]
        public void CrearDoctor_ConApellidoInvalido_DeberiaLanzarArgumentException()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nombre = "Juan";
            var apellido = ""; // Apellido inválido
            var fechaIngreso = new DateTime(2023, 1, 1);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Doctor(id, nombre, apellido, fechaIngreso));
        }

        [Fact]
        public void CrearDoctor_ConFechaIngresoInvalida_DeberiaLanzarArgumentException()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nombre = "Juan";
            var apellido = "Perez";
            var fechaIngreso = DateTime.Now.AddYears(1); // Fecha de ingreso en el futuro

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Doctor(id, nombre, apellido, fechaIngreso));
        }
    }
}
