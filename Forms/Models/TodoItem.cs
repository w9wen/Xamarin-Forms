using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}
