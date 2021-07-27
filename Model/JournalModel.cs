using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Journals.Model
{
    public class JournalModel
    {
        public int Id{ get; set; }

        [Required]
        public string EntryName{ get; set; }

        [Required]
        [Display(Name ="Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date{ get; set; }

        public string Entry{ get; set; }
    }
}
