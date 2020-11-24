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
                "Subtract",
                "90TrnglAreaHypotenuse",
                "90TrnglAreaLegs"
            }, res);
        }

        [Fact]
        public void MyTest()
        {
            // Arrange
            string ns = "ds.test.impl.Ops";
            // Act
            bool c = ns.StartsWith("ds.test.impl.Ops");
            // Assert
            Assert.True(c);
        }
    }
}
