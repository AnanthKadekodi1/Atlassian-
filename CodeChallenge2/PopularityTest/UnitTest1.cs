using CodeChallenge2.PopularityService;

namespace PopularityTest
{
    public class Tests
    {
        private Popularity _popularity;

        [SetUp]
        public void Setup()
        {
            _popularity = new Popularity();
        }

        [Test]
        public void AssessIncreaseAndDecreasePopularity()
        {
            _popularity.increasePopularity(7);
            _popularity.increasePopularity(7);
            _popularity.increasePopularity(8);
            var popular = _popularity.mostPopular();
            Assert.That(popular, Is.EqualTo(7));

            _popularity.increasePopularity(8);
            _popularity.increasePopularity(8);
            popular = _popularity.mostPopular();
            Assert.That(popular, Is.EqualTo(8));

            _popularity.decreasePopularity(8);
            _popularity.decreasePopularity(8);

            popular = _popularity.mostPopular();
            Assert.That(popular, Is.EqualTo(7));

            _popularity.decreasePopularity(7);
            _popularity.decreasePopularity(7);
            _popularity.decreasePopularity(8);
            _popularity.decreasePopularity(8);
            popular = _popularity.mostPopular();
            Assert.That(popular, Is.EqualTo(-1));

        }

        //[Test]
       // public void Test2()
       // {
       //     Assert.Pass();
        //}
    }
}


//Popularity should not be lower than 0 