using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransactionsAPI.DataModels;

[Table(name: "profiles")]
public class Profile
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    public string? name { get; set; }

    public string? email { get; set; }

    public string? img { get; set; }

    public DateTime created_at { get; set; } = DateTime.Now;

    public DateTime updated_at { get; set; } = DateTime.Now;
}
