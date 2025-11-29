using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingApplication.Areas.Identity.Data;

// Add profile data for application users by adding properties to the OnlineVotingApplicationUser class
public class OnlineVotingApplicationUser : IdentityUser
{

    public string? Name { get; set; }
    public string? Mobile { get; set; }
    public string City { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }
    public bool IsVoter { get; set; }
    public bool IsCandidate { get; set; }
    [Required]
    public string ProfileImage { get; set; }
    [NotMapped]
    public object Roles { get; set; }
    [NotMapped]
    public object UserRoles { get; internal set; }
    [NotMapped]
    public object Users { get; internal set; }
}

