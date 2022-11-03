using NuGet.Frameworks;
using VotingSystem;
/*
namespace VotingSystemTests
{
    public class Tests
    {
        private Winner winner;

        [SetUp]
        public void Setup()
        {
            winner = new Winner();

        }

        [Test]
        public void TestCorrectWinnerFound()
        {
            String[] votes
                =
                {
                    "john", "johnny",
                    "john"
                };

            var electionWinner = winner.FindWinner(votes);
            Assert.That(electionWinner, Is.EqualTo("john"));
        }


        [Test]
        public void SelectCorrectWinnerWithTwoWinners()
        {
            String[] votes
                =
                {
                    "john", "johnny",
                    "john", "johnny"
                };

            var electionWinner = winner.FindWinner(votes);
            Assert.That(electionWinner, Is.EqualTo("john"));
        }

        public void SelectCorrectWinnerWithThreeApplicants()
        {
            String[] votes
                =
                {
                    "john", "johnny",
                    "john", "angus"
                };

            var electionWinner = winner.FindWinner(votes);
            Assert.That(electionWinner, Is.EqualTo("john"));
        }
    }
}*/