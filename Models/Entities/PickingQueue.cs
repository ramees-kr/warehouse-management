using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace warehouse_management.Models.Entities;

[Table("pickingQueue")]
public partial class PickingQueue
{
    [Key]
    [Column("picking_id")]
    public int PickingId { get; set; }

    [Column("order_item_id")]
    public int? OrderItemId { get; set; }

    [Column("quantity_to_pick")]
    public int? QuantityToPick { get; set; }

    [ForeignKey("OrderItemId")]
    [InverseProperty("PickingQueues")]
    public virtual OrderItem? OrderItem { get; set; }
}
