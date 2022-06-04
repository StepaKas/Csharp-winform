using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KonzolaCore.Models
{
    [Table("Name_of_event")]
    public class Name_of_event
    {
        public decimal Shift_Id { get; set; }
        public decimal  Event_name_Id { get; set; }
        public override string ToString()
        {
            return $"Shift_Id: {Shift_Id}\nEvent_name_Id: {Event_name_Id}";
        }
    }
}
