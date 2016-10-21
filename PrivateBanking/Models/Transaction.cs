using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateBanking.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1, double.MaxValue, ErrorMessage = "Please enter an amount greater than 0")]
        public decimal Amount { get; set; }

        [Required]
        public int CheckingAccountId { get; set; }
        // set this up as forgien key referecing to checking account table
        public virtual CheckingAccount CheckingAccount { get; set; }
    }
}