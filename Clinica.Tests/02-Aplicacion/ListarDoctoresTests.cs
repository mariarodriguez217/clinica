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
    public class ListarDoctoresTests
    {
        [Fact]
        public void ListarDoctores_DeberiaRetornarListaDeDoctores()
        {
            // Arrange
            var mockRepositorio = new Mock<DoctorRepositorio>();
            var casoDeUso = new ListarDoctores(mockRepositorio.Object);
            var listaDoctores = new List<Doctor>
            {
                new Doctor(Guid.NewGuid(), "Carlos", "Martinez", Especialidad.Oncologia, new DateTime(2020, 1, 1)),
                new Doctor(Guid.NewGuid(), "Ana", "Lopez", Especialidad.Pediatria, new DateTime(2015, 3, 12))
            };
            mockRepositorio.Setup(r => r.listar()).Returns(listaDoctores);

            // Act
            var resultado = casoDeUso.Ejecutar();

            // Assert
            Assert.Equal(2, resultado.Count);
            Assert.Equal(listaDoctores[0].IdD(), resultado[0].IdD());
            Assert.Equal(listaDoctores[0].Nombre(), resultado[0].Nombre());
            Assert.Equal(listaDoctores[0].FechaIngreso(), resultado[0].FechaIngreso());
        }
    }
}
