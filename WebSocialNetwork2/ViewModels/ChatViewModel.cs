using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSocialNetwork2.Models;

namespace WebSocialNetwork2.ViewModels
{
    public class ChatViewModel
    {
        public User You { get; set; }

        public User ToWhom { get; set; }

        public List<Message> History { get; set; }

        public MessageViewModel NewMessage { get; set; }

        public ChatViewModel()
        {
            NewMessage = new MessageViewModel();
        }
    }
}
