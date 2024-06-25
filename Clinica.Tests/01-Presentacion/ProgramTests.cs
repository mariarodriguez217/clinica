using Xunit;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Clinica.Tests.Presentacion
{
    public class ProgramTests
    {
        [Fact]
        public async Task Main_ValidInput_PrintsMessage()
        {
            // Arrange
            using var sw = new StringWriter();
            Console.SetOut(sw);

            using var sr = new StringReader("input data"); // Simular entrada de datos

            // Redirigir Console.In a sr
            Console.SetIn(sr);

            // Act
            await Program.Main(new string[] { });

            // Assert
            var expectedOutput = "Hello, World!";
            Assert.Contains(expectedOutput, sw.ToString());
        }
    }
}
