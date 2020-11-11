using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vote.Models
{
    public class OptionVoting
    {
        [Required]
        public string TitleVoting { get; set; }

        [Required]
        public string DescriptionVoting { get; set; }

        public DateTime Start_dateVoting { get; set; } = DateTime.Now;

        public DateTime End_dateVoting { get; set; } = DateTime.Now;

        public bool haveOption = false;
    }
}
