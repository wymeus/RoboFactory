using System.Drawing;

namespace RoboFactory.Tests
{
    public class RoboHashApiTests
    {
        private Bitmap? imageResult;

        [SetUp]
        public void Setup()
        {
            // Arrange
            var hash = new Random().Next(0, 100).ToString();
            // Act
            imageResult = RoboHashApi.GenerateAsync(hash).Result;
        }

        [TearDown]
        public void Teardown()
        {
            // Dispose
            imageResult?.Dispose();
        }

        [Test]
        public void Generate_ShouldNotReturnNull()
        {
            // Assert
            Assert.That(imageResult, Is.Not.Null);
        }

        [Test]
        public void Generate_ShouldReturnBitmao()
        {
            // Assert
            Assert.That(imageResult, Is.InstanceOf<Bitmap>());
        }

        [Test]
        public void Generate_ShouldReturnDefaultSizeImage()
        {
            // Arrange
            var defaultWidth = 300;
            var defaultHeight = 300;

            // Assert
            Assert.Multiple(() => {
                Assert.That(imageResult?.Width, Is.EqualTo(defaultWidth));
                Assert.That(imageResult?.Height, Is.EqualTo(defaultHeight));
            });
        }
    }
}
