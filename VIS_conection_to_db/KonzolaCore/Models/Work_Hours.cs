using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KonzolaCore.Models
{
    [Table("Work_Hours")]
    public class Work_Hours
    {
        public decimal Id { get; set; }

        public DateTime? Start_time { get; set; } = DateTime.Now;
        public DateTime? End_time { get; set; } = DateTime.Now;
        public decimal Worker_Id { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nStart_time: {Start_time}\nEnd_time: {End_time}\nCreator id: {Worker_Id}";
        }
    }
}
