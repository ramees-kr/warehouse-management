using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace warehouse_management.Models.Entities;

[Table("inventory")]
public partial class Inventory
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("product_id")]
    public int? ProductId { get; set; }

    [Column("size")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Size { get; set; }

    [Column("quantity_available")]
    public int? QuantityAvailable { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("Inventories")]
    public virtual Product? Product { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, ProductId: {ProductId}, Size: {Size}, QuantityAvailable: {QuantityAvailable}";
    }
}
