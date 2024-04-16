using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace warehouse_management.Models.Entities;

[Table("location")]
public partial class Location
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("_aisle")]
    public int? Aisle { get; set; }

    [Column("_row")]
    public int? Row { get; set; }

    [Column("_column")]
    public int? Column { get; set; }

    [InverseProperty("Location")]
    public virtual ICollection<ProductLocation> ProductLocations { get; set; } = new List<ProductLocation>();

    // Add a ToString method to return a string representation of the location
    public override string ToString()
    {
        return $"Aisle: {Aisle}, Row: {Row}, Column: {Column}";
    }
}
