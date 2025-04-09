﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RSPGApplication.Models
{
    public class OtherResource
    {
        [Key]
        public int ORId { get; set; }

        [ForeignKey("BudgetFormId")]
        public int BudgetFormId { get; set; }

        [Required(ErrorMessage = "Please insert a name")]
        public string Name { get; set; }

        public string? FundsFrom1 { get; set; }
        public double Total1 { get; set; } = 0;

        public string? FundsFrom2 { get; set; }
        public double Total2 { get; set; } = 0;

        public string? FundsFrom3 { get; set; }
        public double Total3 { get; set; } = 0;

        public int RSPGTotal { get; set; } = 0;


        public double GetTotal()
        {
            return (Total1 + Total2 + Total3 + RSPGTotal);
        }
    }
}
