using NUnit.Framework;

namespace dotNet_pairing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Example Unit Test
        [Test]
        public void Name_This_Test()
        {
            // Example initial data
            var testInput = new [] { new [] {"*", ".", ".", "."}, new [] {".", ".", "*", "."}, new [] {".", ".", ".", "."}};
            var expectedOutput = new [] {new [] {"*", "2", "1", "1"}, new [] {"1", "2", "*", "1"}, new [] {"0", "1", "1", "1"}};

            var map = new Map();
            
            var result = map.CreateMap(testInput);
            
            // Example Assert
            Assert.That(result.Length, Is.EqualTo(expectedOutput.Length));
        }
    }
}
