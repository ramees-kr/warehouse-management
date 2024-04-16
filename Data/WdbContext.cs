using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using warehouse_management.Models.Entities;

namespace warehouse_management.Data;

public partial class WdbContext : DbContext
{
    public WdbContext()
    {
    }

    public WdbContext(DbContextOptions<WdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<PackedItem> PackedItems { get; set; }

    public virtual DbSet<PickingQueue> PickingQueues { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductLocation> ProductLocations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=RAMEES\\SQLEXPRESS;Initial Catalog=warehousedb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__inventor__3213E83F1A917A89");

            entity.HasOne(d => d.Product).WithMany(p => p.Inventories).HasConstraintName("FK__inventory__produ__44FF419A");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__location__3213E83F70F395A7");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__orders__4659622938455A8A");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PK__orderIte__3764B6BC7F49A53F");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems).HasConstraintName("FK__orderItem__order__45F365D3");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems).HasConstraintName("FK__orderItem__produ__46E78A0C");
        });

        modelBuilder.Entity<PackedItem>(entity =>
        {
            entity.HasKey(e => e.PackedItemId).HasName("PK__packedIt__21A830F0E41FB666");

            entity.HasOne(d => d.OrderItem).WithMany(p => p.PackedItems).HasConstraintName("FK__packedIte__order__47DBAE45");
        });

        modelBuilder.Entity<PickingQueue>(entity =>
        {
            entity.HasKey(e => e.PickingId).HasName("PK__pickingQ__A572C5B57C6025C9");

            entity.HasOne(d => d.OrderItem).WithMany(p => p.PickingQueues).HasConstraintName("FK__pickingQu__order__48CFD27E");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__products__3213E83FA404777A");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__productL__3213E83FBFDAFD58");

            entity.HasOne(d => d.Location).WithMany(p => p.ProductLocations).HasConstraintName("FK__productLo__locat__49C3F6B7");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductLocations).HasConstraintName("FK__productLo__produ__4AB81AF0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
