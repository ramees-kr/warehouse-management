using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace warehouse_management.Models.Entities;

[Table("orderItems")]
public partial class OrderItem
{
    [Key]
    [Column("order_item_id")]
    public int OrderItemId { get; set; }

    [Column("order_id")]
    public int? OrderId { get; set; }

    [Column("product_id")]
    public int? ProductId { get; set; }

    [Column("size")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Size { get; set; }

    [Column("quantity_ordered")]
    public int? QuantityOrdered { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderItems")]
    public virtual Order? Order { get; set; }

    [InverseProperty("OrderItem")]
    public virtual ICollection<PackedItem> PackedItems { get; set; } = new List<PackedItem>();

    [InverseProperty("OrderItem")]
    public virtual ICollection<PickingQueue> PickingQueues { get; set; } = new List<PickingQueue>();

    [ForeignKey("ProductId")]
    [InverseProperty("OrderItems")]
    public virtual Product? Product { get; set; }
}
