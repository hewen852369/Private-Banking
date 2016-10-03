using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateBanking.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Account #")]
        //[StringLength(10,MinimumLength = 6)]
        //few attributes for code first migration
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Account # must be between 6 and 10 digits.")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        // as forgien key to referncing to userapplication table(who holds account)
        // enable lazy loading
        public virtual ApplicationUser User { get; set; }

        // adding user id
        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}