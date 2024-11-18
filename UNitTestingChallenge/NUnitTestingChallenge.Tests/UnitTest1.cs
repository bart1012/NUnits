using UNitTestingChallenge;


namespace NUnitTestingChallenge.Tests
{
    public class Tests
    {
        Compass myCompass;

        [SetUp]
        public void Setup()
        {
            myCompass = new Compass(Point.South);
        }

        [Test]
        public void Test1()
        {
            var rotateResult = myCompass.Rotate(Point.North, Direction.Right);
            //Assert.That(rotateResult, Is.EqualTo(Point.East);
        }
    }
}