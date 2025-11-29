using OnlineVotingApplication.Areas.Identity.Data;
using System;
using System.Collections.Generic;

namespace OnlineVotingApplication.ViewModel
{
    public class ConvertApplicationUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public bool IsVoter { get; set; }
        public string ProfileImage { get; set; }

        public List<ConvertApplicationUser> ApplicationUsers { get; set; }

        public ConvertApplicationUser()
        {
            ApplicationUsers = new List<ConvertApplicationUser>();
        }

        public ConvertApplicationUser(List<OnlineVotingApplicationUser> users)
        {
            ApplicationUsers = new List<ConvertApplicationUser>();

            foreach (var user in users)
            {
                ApplicationUsers.Add(new ConvertApplicationUser
                {
                    Id = user.Id,
                    Email = user.Email,
                    Name = user.Name,
                    Mobile = user.Mobile,
                    City = user.City,
                    BirthDate = user.BirthDate,
                    Address = user.Address,
                    IsVoter = user.IsVoter,
                    ProfileImage = user.ProfileImage
                });
            }
        }

        public static ConvertApplicationUser EditConvertModel(OnlineVotingApplicationUser user)
        {
            return new ConvertApplicationUser
            {
                Id = user.Id,
                IsVoter = user.IsVoter
            };
        }
    }
}
