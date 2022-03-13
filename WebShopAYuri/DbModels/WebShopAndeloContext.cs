using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebShopAYuri.DbModels
{
    public partial class WebShopAndeloContext : DbContext
    {
        public WebShopAndeloContext()
        {
        }

        public WebShopAndeloContext(DbContextOptions<WebShopAndeloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<LogInfo> LogInfo { get; set; }
        public virtual DbSet<NacinPlacanja> NacinPlacanja { get; set; }
        public virtual DbSet<Proizvod> Proizvod { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=WebShopAndelo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Iditem)
                    .HasName("PK__Item__C9778A1098DF0069");

                entity.Property(e => e.Iditem).HasColumnName("IDItem");

                entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.ProizvodId)
                    .HasConstraintName("FK__Item__ProizvodID__31EC6D26");

                entity.HasOne(d => d.Racun)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.RacunId)
                    .HasConstraintName("FK__Item__RacunID__30F848ED");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.HasKey(e => e.Idkategorija)
                    .HasName("PK__Kategori__7E48B6E5965D17D6");

                entity.Property(e => e.Idkategorija).HasColumnName("IDKategorija");

                entity.Property(e => e.Naziv).HasMaxLength(30);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.HasKey(e => e.Idkorisnik)
                    .HasName("PK__Korisnik__6F9CD5C481D877FC");

                entity.Property(e => e.Idkorisnik).HasColumnName("IDKorisnik");

                entity.Property(e => e.Adresa).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Ime).HasMaxLength(30);

                entity.Property(e => e.KorisnikPassword).HasMaxLength(30);

                entity.Property(e => e.Prezime).HasMaxLength(30);
            });

            modelBuilder.Entity<LogInfo>(entity =>
            {
                entity.HasKey(e => e.IdlogInfo)
                    .HasName("PK__LogInfo__844891895AB66C85");

                entity.Property(e => e.IdlogInfo).HasColumnName("IDLogInfo");

                entity.Property(e => e.Ipadress)
                    .HasColumnName("IPAdress")
                    .HasMaxLength(300);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.LogDate).HasMaxLength(50);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.LogInfo)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__LogInfo__Korisni__32E0915F");
            });

            modelBuilder.Entity<NacinPlacanja>(entity =>
            {
                entity.HasKey(e => e.IdnacinPlacanja)
                    .HasName("PK__NacinPla__D431C3C9298DF255");

                entity.Property(e => e.IdnacinPlacanja).HasColumnName("IDNacinPlacanja");

                entity.Property(e => e.NacinPlacanjaNaziv).HasMaxLength(30);
            });

            modelBuilder.Entity<Proizvod>(entity =>
            {
                entity.HasKey(e => e.Idproizvod)
                    .HasName("PK__Proizvod__51B7B049AF2AB353");

                entity.Property(e => e.Idproizvod).HasColumnName("IDProizvod");

                entity.Property(e => e.Img).HasMaxLength(200);

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Marka).HasMaxLength(40);

                entity.Property(e => e.Naziv).HasMaxLength(30);

                entity.Property(e => e.Opis).HasMaxLength(300);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Proizvod)
                    .HasForeignKey(d => d.KategorijaId)
                    .HasConstraintName("FK__Proizvod__Katego__33D4B598");
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.HasKey(e => e.Idracun)
                    .HasName("PK__Racun__84F24C96267B93EF");

                entity.Property(e => e.Idracun).HasColumnName("IDRacun");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.NacinPlacanjaId).HasColumnName("NacinPlacanjaID");

                entity.Property(e => e.RacunDatum).HasMaxLength(50);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Racun)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Racun__KorisnikI__2F10007B");

                entity.HasOne(d => d.NacinPlacanja)
                    .WithMany(p => p.Racun)
                    .HasForeignKey(d => d.NacinPlacanjaId)
                    .HasConstraintName("FK__Racun__NacinPlac__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
