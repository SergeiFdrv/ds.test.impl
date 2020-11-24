using System;
using Xunit;
using ds.test.impl;

namespace ds.test.impl.Tests
{
    public class FactoryTests
    {
        [Fact]
        public void PluginCount_Counts()
        {
            // Arrange
            // Act
            int res = new Plugins().PluginsCount;
            // Assert
            Assert.Equal(7, res);
        }

        [Fact]
        public void PluginNameList_Loads()
        {
            // Arrange
            // Act
            string[] res = new Plugins().GetPluginNames;
            // Assert
            Assert.Equal(new string[]
            {
                "Add",
                "Divide",
                "Multiply",
                "Remainder",
                "90TrnglAreaHypothenuse",
                "90TrnglAreaLegs",
                "Subtract"
            }, res);
        }
    }
}
