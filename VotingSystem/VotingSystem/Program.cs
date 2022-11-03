
namespace VotingSystem
{
    public class Voting
    {
        public static void Main(string[] args)
        {
            String[] votes
                =
                {
                    //"WXYZ","XYZW"
                    //"eat","tea","tan","ate","nat","bat"
                    "ABC","ACB","ABC", "ACM"
                };

            //MaxNumberOfOccurences max = new MaxNumberOfOccurences();
            //max.MaxFreq("aababcaab", 2, 3, 4);
            RankTeamsByVotes x = new RankTeamsByVotes();
            var y = x.RankTeams(votes);
            Console.WriteLine(y);
            //Anagrams a = new Anagrams();
            //a.GroupAnagrams(votes);
            //var electionWinner2 = winner.RankTeams(votes);
            //Console.WriteLine(electionWinner2);
            //ValidParenthesis v = new ValidParenthesis();
            //v.IsValid("()");
            //GreatestCommonDivisor gcd = new GreatestCommonDivisor();
            //gcd.GcdOfStrings("ABCABC", "ABC");
        }
    }
}
