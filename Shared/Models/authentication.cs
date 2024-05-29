using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prroject.Shared.Models
{
    public class authentication
    {
        [Key]
        public string email {  get; set; }
        public string? username { get; set; }
        public string password { get; set; }
    }
}
