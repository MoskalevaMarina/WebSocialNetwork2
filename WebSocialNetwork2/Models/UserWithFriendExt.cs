using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSocialNetwork2.Models
{
    public class UserWithFriendExt : User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}
