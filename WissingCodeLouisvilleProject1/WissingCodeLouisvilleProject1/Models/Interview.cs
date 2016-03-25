using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WissingCodeLouisvilleProject1.Models
{
    

    public class Interview
    {
        public int InterviewID { get; set; }

        [Required]
        [DisplayName("Interviewer First Name")]
        public string InterviewerFirstName { get; set; }

        [Required]
        [DisplayName("Interviewer Last Name")]
        public string InterviewerLastName { get; set; }

        [Required]
        [DisplayName("Interviewee First Name")]
        public string IntervieweeFirstName { get; set; }

        [Required]
        [DisplayName("Interviewee Last Name")]
        public string IntervieweeLastName { get; set; }

        [Required]
        [DisplayName("Location (City, State)")]
        public string Location { get; set; }

        [Required]
        [DisplayName("Name of Event")]
        public string EventName { get; set; }

        [Required]
        [DisplayName("Date (MM/DD/YYYY)")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [DisplayName("Duration (Seconds)")]
        public int Duration { get; set; }

        public string Notes { get; set; }
              
    }
}