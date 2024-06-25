using Xunit;
using _02_Aplicacion;
using _02_Aplicacion.DTOs;
using Moq;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;
using System;
using System.Collections.Generic;

namespace Clinica.Tests.Aplicacion
{
    public class ListarPacientesTests
    {
        [Fact]
        public void ListarPacientes_DeberiaRetornarListaDePacientes()
        {
            // Arrange
            var mockRepositorio = new Mock<PacienteRepositorio>();
            var casoDeUso = new ListarPacientes(mockRepositorio.Object);
            var listaPacientes = new List<Paciente>
            {
                new Paciente(Guid.NewGuid(), "Maria", "Gomez", new DateTime(1995, 5, 10)),
                new Paciente(Guid.NewGuid(), "Juan", "Perez", new DateTime(1980, 6, 20))
            };
            mockRepositorio.Setup(r => r.listar()).Returns(listaPacientes);

            // Act
            var resultado = casoDeUso.Ejecutar();

            // Assert
            Assert.Equal(2, resultado.Count);
            Assert.Equal(listaPacientes[0].IdP(), resultado[0].IdP());
            Assert.Equal(listaPacientes[0].Nombre(), resultado[0].Nombre());
            Assert.Equal(listaPacientes[0].FechaNacimiento(), resultado[0].FechaNacimiento());
        }
    }
}
