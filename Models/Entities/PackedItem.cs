using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace warehouse_management.Models.Entities;

[Table("packedItems")]
public partial class PackedItem
{
    [Key]
    [Column("packed_item_id")]
    public int PackedItemId { get; set; }

    [Column("order_item_id")]
    public int? OrderItemId { get; set; }

    [Column("quantity_packed")]
    public int? QuantityPacked { get; set; }

    [ForeignKey("OrderItemId")]
    [InverseProperty("PackedItems")]
    public virtual OrderItem? OrderItem { get; set; }
}
