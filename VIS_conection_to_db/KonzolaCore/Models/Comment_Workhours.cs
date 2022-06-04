using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KonzolaCore.Models
{
    [Table("Comment_Workhours")]
    public class Comment_Workhours
    {
        public decimal Id { get; set; }

        public DateTime? Time_Created { get; set; } = DateTime.Now;
        public string Text { get; set; } 
        public decimal Work_Hours_ID { get; set; }

        public override string ToString()
        {
            string s = $"Id: {Id}\nTime_Created: {Time_Created}\nText: {Text}\nWork_Hours_ID: {Work_Hours_ID} ";
            return s;
        }
    }
}
