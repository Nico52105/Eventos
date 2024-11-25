using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Datos.Entidades;

public partial class AgendaContext : DbContext
{
    public AgendaContext()
    {
    }

    public AgendaContext(DbContextOptions<AgendaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Confirmacione> Confirmaciones { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MANILU\\SQLEXPRESS;Initial Catalog=Agenda;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Confirmacione>(entity =>
        {
            //entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.Confirmaciones)
                .HasForeignKey(d => d.IdEvento)
                .HasConstraintName("FK_Confirmaciones_Eventos");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Confirmaciones)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_Confirmaciones_Usuarios");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            //entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Imagen)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_Eventos_Usuarios");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            //entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Clave)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
