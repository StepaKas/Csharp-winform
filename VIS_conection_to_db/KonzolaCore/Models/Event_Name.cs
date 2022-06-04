using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KonzolaCore.Models
{
    [Table("Event_Name")]
    public class Event_Name
    {
        public decimal Id { get; set; }

        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}";
        }
    }
}
