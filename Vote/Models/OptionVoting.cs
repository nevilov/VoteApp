using System;
using System.ComponentModel.DataAnnotations;

namespace Vote.Models
{
    public class OptionVoting
    {
        public string Id { get; set; }

        [Required]
        public string TitleVoting { get; set; }

        [Required]
        public string DescriptionVoting { get; set; }

        public DateTime Start_dateVoting { get; set; } = DateTime.Now;

        public DateTime End_dateVoting { get; set; } = DateTime.Now;

        public string[] listOptions = new string[5];


    }
}
