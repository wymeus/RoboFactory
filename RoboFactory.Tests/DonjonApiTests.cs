namespace RoboFactory.Tests
{
    public class Tests
    {
        private List<string> runonceSingleNameResult;
        private List<string> runonceFiveNamesResult;

        [SetUp]
        public void Setup()
        {
            // Arrange
            runonceSingleNameResult = DonjonApi.GetRandomNamesAsync(amount: 1).Result;
            runonceFiveNamesResult = DonjonApi.GetRandomNamesAsync(amount: 5).Result;
        }

        [Test]
        public void GetRandomNames_ShouldNotReturnNull()
        {
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(runonceSingleNameResult, Is.Not.Null);
                Assert.That(runonceFiveNamesResult, Is.Not.Null);
            });
        }

        [Test]
        public void GetRandomNames_ShouldReturnListOfString()
        {
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(runonceSingleNameResult, Is.InstanceOf<List<string>>());
                Assert.That(runonceFiveNamesResult, Is.InstanceOf<List<string>>());
            });
        }

        [Test]
        public void GetRandomNames_ShouldNotReturnEmptyList()
        {
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(runonceSingleNameResult, Is.Not.Empty);
                Assert.That(runonceFiveNamesResult, Is.Not.Empty);
            });
        }

        [Test]
        public void GetRandomNames_ShouldReturnCorrectCount()
        {
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(runonceSingleNameResult, Has.Count.EqualTo(1));
                Assert.That(runonceFiveNamesResult, Has.Count.EqualTo(5));
            });
        }
    }
}