using System;
using Xunit;
using ds.test.impl;

namespace ds.test.impl.Tests
{
    public class PluginsTests
    {
        [Fact]
        public void Addition_Adds()
        {
            // Arrange
            IPlugin plugin = new Plugins().GetPlugin("Add");
            // Act
            int res = plugin.Run(8, 4);
            // Assert
            Assert.Equal(12, res);
        }

        [Fact]
        public void Subtraction_Subtracts()
        {
            // Arrange
            IPlugin plugin = new Plugins().GetPlugin("Subtract");
            // Act
            int res = plugin.Run(8, 4);
            // Assert
            Assert.Equal(4, res);
        }

        [Fact]
        public void Multiplication_Multiplies()
        {
            // Arrange
            IPlugin plugin = new Plugins().GetPlugin("Multiply");
            // Act
            int res = plugin.Run(8, 4);
            // Assert
            Assert.Equal(32, res);
        }

        [Fact]
        public void Division_Divides()
        {
            // Arrange
            IPlugin plugin = new Plugins().GetPlugin("Divide");
            // Act
            int res = plugin.Run(7, 4);
            // Assert
            Assert.Equal(1, res);
        }

        [Fact]
        public void Remainder_IsRight()
        {
            // Arrange
            IPlugin plugin = new Plugins().GetPlugin("Remainder");
            // Act
            int res = plugin.Run(7, 4);
            // Assert
            Assert.Equal(3, res);
        }
    }
}
