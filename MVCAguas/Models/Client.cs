using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAguas.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public int Age {
            get
            {
                var myAge = DateTime.Now.Year - DateOfBirth.Year;

                if (DateOfBirth > DateTime.Now.AddYears(-myAge))
                {
                    myAge--;
                }
                return myAge;
            }
        }

        [Display(Name ="E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //Ligação com a outra tabela/modelo
        [Display(Name ="City")]
        [Required(ErrorMessage ="City must be selected")]
        [Range(1, double.MaxValue, ErrorMessage ="City must be selected")]
        public int AddressID { get; set; }

        public virtual Location Location { get; set; }

    }
}