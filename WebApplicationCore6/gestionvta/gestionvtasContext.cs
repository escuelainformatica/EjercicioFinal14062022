using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.gestionvta
{
    public partial class gestionvtasContext : DbContext
    {
        public gestionvtasContext()
        {
        }

        public gestionvtasContext(DbContextOptions<gestionvtasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Detalledctos> Detalledctos { get; set; }
        public virtual DbSet<Facturasvtas> Facturasvtas { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Tiposdedoctos> Tiposdedoctos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=abc.123;database=gestionvtas");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Idclientes)
                    .HasName("PRIMARY");

                entity.ToTable("clientes");

                entity.Property(e => e.Idclientes).HasColumnName("idclientes");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(55)
                    .HasColumnName("direccion");

                entity.Property(e => e.Montocredito).HasColumnName("montocredito");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(55)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rut)
                    .HasMaxLength(15)
                    .HasColumnName("rut");
            });

            modelBuilder.Entity<Detalledctos>(entity =>
            {
                entity.HasKey(e => e.Tipodcto)
                    .HasName("PRIMARY");

                entity.ToTable("detalledctos");

                entity.HasIndex(e => e.Idfactvta, "detalledctos_fk1_idx");

                entity.HasIndex(e => e.Idproductos, "detalledctos_fk2_idx");

                entity.Property(e => e.Tipodcto)
                    .HasMaxLength(2)
                    .HasColumnName("tipodcto");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10,0)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Detalledctoscol)
                    .HasMaxLength(45)
                    .HasColumnName("detalledctoscol");

                entity.Property(e => e.Idfactvta).HasColumnName("idfactvta");

                entity.Property(e => e.Idproductos).HasColumnName("idproductos");

                entity.Property(e => e.Nrodcto).HasColumnName("nrodcto");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Rut)
                    .HasMaxLength(15)
                    .HasColumnName("rut");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdfactvtaNavigation)
                    .WithMany(p => p.Detalledctos)
                    .HasForeignKey(d => d.Idfactvta)
                    .HasConstraintName("detalledctos_fk1");

                entity.HasOne(d => d.IdproductosNavigation)
                    .WithMany(p => p.Detalledctos)
                    .HasForeignKey(d => d.Idproductos)
                    .HasConstraintName("detalledctos_fk2");
            });

            modelBuilder.Entity<Facturasvtas>(entity =>
            {
                entity.HasKey(e => e.Idfactvta)
                    .HasName("PRIMARY");

                entity.ToTable("facturasvtas");

                entity.Property(e => e.Idfactvta).HasColumnName("idfactvta");

                entity.Property(e => e.Fechadcto)
                    .HasColumnType("date")
                    .HasColumnName("fechadcto");

                entity.Property(e => e.Nrodcto).HasColumnName("nrodcto");

                entity.Property(e => e.Rut)
                    .HasMaxLength(15)
                    .HasColumnName("rut");

                entity.Property(e => e.Statusdcto)
                    .HasColumnType("tinyint")
                    .HasColumnName("statusdcto");

                entity.Property(e => e.Tipodcto)
                    .HasMaxLength(2)
                    .HasColumnName("tipodcto");

                entity.Property(e => e.Totalbruto).HasColumnName("totalbruto");

                entity.Property(e => e.Totaliva).HasColumnName("totaliva");

                entity.Property(e => e.Totalneto).HasColumnName("totalneto");

                entity.Property(e => e.Totalpago).HasColumnName("totalpago");

                entity.Property(e => e.Totalsaldo).HasColumnName("totalsaldo");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.Idproductos)
                    .HasName("PRIMARY");

                entity.ToTable("productos");

                entity.Property(e => e.Idproductos).HasColumnName("idproductos");

                entity.Property(e => e.Descrispcion)
                    .HasMaxLength(45)
                    .HasColumnName("descrispcion");

                entity.Property(e => e.Preciocom).HasColumnName("preciocom");

                entity.Property(e => e.Preciovta).HasColumnName("preciovta");
            });

            modelBuilder.Entity<Tiposdedoctos>(entity =>
            {
                entity.HasKey(e => e.Idtiposdedoctos)
                    .HasName("PRIMARY");

                entity.ToTable("tiposdedoctos");

                entity.Property(e => e.Idtiposdedoctos).HasColumnName("idtiposdedoctos");

                entity.Property(e => e.Nombredcto)
                    .HasMaxLength(45)
                    .HasColumnName("nombredcto");

                entity.Property(e => e.Tipodcto)
                    .HasMaxLength(2)
                    .HasColumnName("tipodcto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
