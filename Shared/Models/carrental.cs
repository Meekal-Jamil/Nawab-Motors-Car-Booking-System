using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prroject.Shared.Models
{
    public class carrental
    {
        [Key]
        public int car_no {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string pickup { get; set; }
        public string vehicle { get; set; }
        public string price { get; set; }
        public string ph_no { get; set; }
        public string l_no { get; set; }
    }
}
