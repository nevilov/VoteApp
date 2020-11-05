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
        public string TitleVoting { get; set; }

        [Required]
        public string DescriptionVoting { get; set; }

        [Required]
        public DateTime Start_dateVoting { get; set; } = DateTime.Now;

        [Required]
        public DateTime End_dateVoting { get; set; } = DateTime.Now;

        public bool haveOption = false;
        public string additionalOption = "+ Add option";
        public string propertyOptionButton = "btn btn-outline-secondary";


        public void Submit() {
            //Делаю вид, что отправляю данные на сервер
            //Но нет
        }

    }
}
