﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCrudDemo.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account number")]
        public string AccountNumber { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Account owner")]
        public string AccountOwner { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank name")]
        public string BankName { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
