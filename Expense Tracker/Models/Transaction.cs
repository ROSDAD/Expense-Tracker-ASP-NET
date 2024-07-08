using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "varchar(75)")]
        public string? Note { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
