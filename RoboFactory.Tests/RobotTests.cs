using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboFactory.Tests
{
    public class RobotTests
    {
        private Robot? robot;

        [SetUp]
        public void Setup()
        {
            // Arrange
            robot = Robot.GenerateAsync().Result;
        }

        [TearDown] public void Teardown()
        {
            
        }

        [Test]
        public void Generate_ShouldNotReturnNull()
        {
            // Assert
            Assert.That(robot, Is.Not.Null);
        }
    }
}
