using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransactionsAPI.DataModels;
[Table(name: "transactions")]
public class Transaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int tid { get; set; }

    public int profileid { get; set; }

    public string? name { get; set; }

    public int? category { get; set; }

    public string? summary { get; set; }

    public int? amount { get; set; }

    public string? payment_gateway { get; set; }

    public DateTime created_at { get; set; } = DateTime.Now;

    public DateTime updated_at { get; set; } = DateTime.Now;
}
