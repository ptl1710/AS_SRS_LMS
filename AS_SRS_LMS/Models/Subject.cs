﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       
        public string idSubject { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfPeriod { get; set; }

        public List<detailSubject> detailSubjects { get; set; }

        public List<Document> Documents { get; set; }

    }
}
