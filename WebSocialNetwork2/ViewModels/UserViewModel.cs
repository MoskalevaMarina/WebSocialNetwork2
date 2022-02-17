using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSocialNetwork2.Models;

namespace WebSocialNetwork2.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }
        public List<User> Friends { get; set; }

        public UserViewModel(User user)
        {
            User = user;
            Friends = new List<User>();
        }
    }
}
