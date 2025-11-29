namespace OnlineVotingApplication.Areas.Identity.Data
{
    public class Vote
    {

        public int Id { get; set; }
        public string OnlineVotingApplicationUserId { get; set; }
        public string CandidateId { get; set; }
        public DateTime Date { get; set; }
        public OnlineVotingApplicationUser ApplicationUser { get; set; }
        public OnlineVotingApplicationUser Candidate { get; set; }
    }
}
