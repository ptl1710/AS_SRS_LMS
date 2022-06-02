﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class TestSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string idTestSchedule { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Time { get; set; }

        public List<Exam> Exam { get; set; }

    }
}
