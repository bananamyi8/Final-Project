namespace OnlineVotingApplication.Areas.Identity.Data
{
    public class Candidate : OnlineVotingApplicationUser
    {
        public bool IsCandidate { get; set; }
        public  string CandidateName { get; set;}
        public string CandidateSign { get; set;}
        public string Course { get; set; }
        public string YearLevel { get; set; }
        public string Position { get; set; }
        public string Achievement { get; set; }
        public string Platforms { get; set; }
        public ICollection<Vote> Votes { get; set;}
    }
}
