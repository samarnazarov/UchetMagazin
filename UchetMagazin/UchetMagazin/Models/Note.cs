using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace UchetMagazin.Models
{
    class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime date { get; set; }
        public string category {  get; set; }
        public int sum { get; set; }
    }
}
