using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VoteServer
{
    public class VoteInfo
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       [Key]
    
        public string TitleVoting { get; set; }

        public string DescriptionVoting { get; set; }

        public DateTime Start_dateVoting { get; set; } = DateTime.Now;

        public DateTime End_dateVoting { get; set; } = DateTime.Now;

        public string[] listOptions = new string[5];
    }
}
