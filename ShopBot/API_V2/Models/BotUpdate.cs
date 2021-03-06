﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBot.API_V2.Models
{
    public class BotUpdate
    {
        public string MessageText { get; set; }
        public long ChatId { get; set; }
        public int MessageId { get; set; }
        public string CallbackData { get; set; }
        public int CallbackMessageId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
