using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace warehouse_management.Models.Entities;

[Table("productLocation")]
public partial class ProductLocation
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("location_id")]
    public int? LocationId { get; set; }

    [Column("product_id")]
    public int? ProductId { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("ProductLocations")]
    public virtual Location? Location { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductLocations")]
    public virtual Product? Product { get; set; }
}
