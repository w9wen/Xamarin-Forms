using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Models
{
    public class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public string Period
        {
            get
            {
                return String.Format("{0} - {1}", 
                    CheckIn.ToString("yyyy-MM-dd"),
                    CheckOut.ToString("yyyy-MM-dd"));
            }
        }
    }
}
