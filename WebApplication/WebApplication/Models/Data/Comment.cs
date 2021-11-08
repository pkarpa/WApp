﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.Data
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string OwnerId { get; set; }
        public int BookId { get; set; }
        public DateTime Time { get; set; }
        public string Text { get; set; }
    }
}
