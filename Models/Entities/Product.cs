using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace warehouse_management.Models.Entities;

[Table("products")]
public partial class Product
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("gender")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("masterCategory")]
    [StringLength(255)]
    [Unicode(false)]
    public string? MasterCategory { get; set; }

    [Column("subCategory")]
    [StringLength(255)]
    [Unicode(false)]
    public string? SubCategory { get; set; }

    [Column("articleType")]
    [StringLength(255)]
    [Unicode(false)]
    public string? ArticleType { get; set; }

    [Column("baseColour")]
    [StringLength(255)]
    [Unicode(false)]
    public string? BaseColour { get; set; }

    [Column("season")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Season { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("usage")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Usage { get; set; }

    [Column("productDisplayName")]
    [StringLength(255)]
    [Unicode(false)]
    public string? ProductDisplayName { get; set; }

    [Column("weight")]
    public double? Weight { get; set; }

    [Column("price", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    [InverseProperty("Product")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductLocation> ProductLocations { get; set; } = new List<ProductLocation>();
}
