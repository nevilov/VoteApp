using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vote
{
    public class OptionVoting
    {
        [Required]
        public string titleVoting { get; set; }

        [Required]
        public string descriptionVoting { get; set; }

        [Required]
        public DateTime start_dateVoting { get; set; } = DateTime.Now;

        [Required]
        public DateTime end_dateVoting { get; set; } = DateTime.Now;

        public bool haveOption = false;
        public string additionalOption = "+ Add option";
        public string propertyOptionButton = "btn btn-outline-secondary";


    }
}
