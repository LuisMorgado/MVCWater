using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAguas.Models
{
    public class Location
    {
        [Key]
        [Display(Name = "City")]
        public int AddressID { get; set; }

        [Display(Name ="City")]
        public string AddressName { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        

    }
}