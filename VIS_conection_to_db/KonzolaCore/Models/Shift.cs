using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KonzolaCore.Models
{
    [Table("Shift")]
    public class Shift
    {
        public decimal Id { get; set; }

        public DateTime Start_time { get; set; } = DateTime.Now;
        public DateTime End_time { get; set; } = DateTime.Now;
        public decimal Capacity { get; set; }
        public decimal Work_hours_Id { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nStart_time: {Start_time}\nEnd_time: {End_time}\nCapacity: {Capacity}\nWork_hours_Id: {Work_hours_Id}";
        }
    }
}
