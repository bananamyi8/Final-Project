using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineVotingApplication.ViewModel
{
    public class CreateCandidate
    {
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public bool IsVoter { get; set; }
        public IFormFile ProfileImage { get; set; }
        [NotMapped]
        public object Roles { get; set; }
        [NotMapped]
        public object UserRoles { get; internal set; }
        [NotMapped]
        public object Users { get; internal set; }
        public bool IsCandidate { get; set; }
        public IFormFile CandidateSign { get; set; }
    }
}
