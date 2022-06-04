using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KonzolaCore.Models
{
    [Table("Worker_is_logged_to_shift")]
    public class Worker_is_logged_to_shift
    {
        public decimal Worker_Id { get; set; }
        public decimal Shift_Id { get; set; }
        public override string ToString()
        {
            return $"Id: {Worker_Id}\nShift_Id: {Shift_Id}";
        }

    }
}
