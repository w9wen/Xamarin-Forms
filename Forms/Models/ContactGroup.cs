using System;
using System.Collections.Generic;

namespace Forms.Models
{
    public class ContactGroup:List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
