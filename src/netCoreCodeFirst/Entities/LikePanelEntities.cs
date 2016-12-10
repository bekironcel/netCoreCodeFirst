using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace netCoreCodeFirst.Entities
{
    public partial class LikePanelEntities : DbContext
    {
        public virtual DbSet<BaslangicSilk> BaslangicSilk { get; set; }
        public virtual DbSet<Duyuru> Duyuru { get; set; }
        public virtual DbSet<DuyuruResim> DuyuruResim { get; set; }
        public virtual DbSet<GoldSilkTur> GoldSilkTur { get; set; }
        public virtual DbSet<GuidHavuz> GuidHavuz { get; set; }
        public virtual DbSet<IndirmeLink> IndirmeLink { get; set; }
        public virtual DbSet<Karaktergorselleri> Karaktergorselleri { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<MagazaEquipUrun> MagazaEquipUrun { get; set; }
        public virtual DbSet<MagazaSilkGold> MagazaSilkGold { get; set; }
        public virtual DbSet<MarketLog> MarketLog { get; set; }
        public virtual DbSet<RankOdul> RankOdul { get; set; }
        public virtual DbSet<RankOdulLog> RankOdulLog { get; set; }
        public virtual DbSet<RankOdulTur> RankOdulTur { get; set; }
        public virtual DbSet<RankSureAyar> RankSureAyar { get; set; }
        public virtual DbSet<RankTur> RankTur { get; set; }
        public virtual DbSet<SifreDegistirme> SifreDegistirme { get; set; }
        public virtual DbSet<SiteBolumAcKapa> SiteBolumAcKapa { get; set; }
        public virtual DbSet<SliderResim> SliderResim { get; set; }
        public virtual DbSet<TlBakiye> TlBakiye { get; set; }
        public virtual DbSet<TlEpinLog> TlEpinLog { get; set; }
        public virtual DbSet<TlSilkEpin> TlSilkEpin { get; set; }
        public virtual DbSet<TlSilkTur> TlSilkTur { get; set; }
        public virtual DbSet<UniquesForRank> UniquesForRank { get; set; }
        public virtual DbSet<UyeLog> UyeLog { get; set; }

        // Unable to generate entity type for table 'dbo._Log_Global'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._Log_Unique'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.__UniqueRank'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._CurrentOnline'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=192.168.1.102,1433;Initial Catalog=Likepanel;User ID=sa;Password=Bekogx.68");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaslangicSilk>(entity =>
            {
                entity.ToTable("Baslangic_Silk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BaslangicSilk1).HasColumnName("Baslangic_Silk");
            });

            modelBuilder.Entity<Duyuru>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baslik).HasMaxLength(50);

                entity.Property(e => e.EklenmeTarihi)
                    .HasColumnName("Eklenme_Tarihi")
                    .HasColumnType("datetime");

                entity.Property(e => e.Icerik).HasColumnType("text");

                entity.HasOne(d => d.ResimTurNavigation)
                    .WithMany(p => p.Duyuru)
                    .HasForeignKey(d => d.ResimTur)
                    .HasConstraintName("FK_Duyuru_Duyuru_Resim");
            });

            modelBuilder.Entity<DuyuruResim>(entity =>
            {
                entity.ToTable("Duyuru_Resim");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ResimYol).HasMaxLength(65);
            });

            modelBuilder.Entity<GoldSilkTur>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SilkTur)
                    .IsRequired()
                    .HasColumnName("Silk_Tur")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GuidHavuz>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_Guid_Havuz");

                entity.ToTable("Guid_Havuz");

                entity.Property(e => e.Guid).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IndirmeLink>(entity =>
            {
                entity.ToTable("indirme_Link");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DosyaAdi)
                    .HasColumnName("Dosya_Adi")
                    .HasMaxLength(50);

                entity.Property(e => e.DosyaBoyutu)
                    .HasColumnName("Dosya_Boyutu")
                    .HasMaxLength(50);

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.Saglayici).HasMaxLength(50);
            });

            modelBuilder.Entity<Karaktergorselleri>(entity =>
            {
                entity.ToTable("karaktergorselleri");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Imgid)
                    .HasColumnName("imgid")
                    .HasMaxLength(50);

                entity.Property(e => e.Karakterid).HasColumnName("karakterid");
            });

            modelBuilder.Entity<Kullanicilar>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kadi).HasMaxLength(50);

                entity.Property(e => e.Sifre).HasMaxLength(50);
            });

            modelBuilder.Entity<MagazaEquipUrun>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Guid).HasMaxLength(50);

                entity.Property(e => e.ItemAdi)
                    .HasColumnName("Item_Adi")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemKodu)
                    .HasColumnName("Item_Kodu")
                    .HasMaxLength(50);

                entity.Property(e => e.Resim).HasMaxLength(50);

                entity.Property(e => e.UrunEklenmeTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<MagazaSilkGold>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Bonus).HasDefaultValueSql("0");

                entity.Property(e => e.Guid).HasMaxLength(50);

                entity.HasOne(d => d.SilkTurNavigation)
                    .WithMany(p => p.MagazaSilkGold)
                    .HasForeignKey(d => d.SilkTur)
                    .HasConstraintName("FK_MagazaSilkGold_GoldSilkTur");
            });

            modelBuilder.Entity<MarketLog>(entity =>
            {
                entity.ToTable("Market_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HesapAdi)
                    .HasColumnName("Hesap_Adi")
                    .HasMaxLength(65);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.UrunAdi)
                    .HasColumnName("Urun_Adi")
                    .HasMaxLength(65);
            });

            modelBuilder.Entity<RankOdul>(entity =>
            {
                entity.ToTable("Rank_Odul");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.OdulTurNavigation)
                    .WithMany(p => p.RankOdulOdulTurNavigation)
                    .HasForeignKey(d => d.OdulTur)
                    .HasConstraintName("FK_Rank_Odul_Rank_Odul_Tur");

                entity.HasOne(d => d.OdulTur2Navigation)
                    .WithMany(p => p.RankOdulOdulTur2Navigation)
                    .HasForeignKey(d => d.OdulTur2)
                    .HasConstraintName("FK_Rank_Odul_Rank_Odul_Tur1");

                entity.HasOne(d => d.OdulUniqueNavigation)
                    .WithMany(p => p.RankOdul)
                    .HasForeignKey(d => d.OdulUnique)
                    .HasConstraintName("FK_Rank_Odul_Rank_Tur");
            });

            modelBuilder.Entity<RankOdulLog>(entity =>
            {
                entity.ToTable("RankOdul_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bonus).HasMaxLength(15);

                entity.Property(e => e.KarakterAdi)
                    .HasColumnName("Karakter_Adi")
                    .HasMaxLength(65);

                entity.Property(e => e.Odul).HasMaxLength(15);

                entity.Property(e => e.Rank).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<RankOdulTur>(entity =>
            {
                entity.ToTable("Rank_Odul_Tur");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Turu).HasMaxLength(50);
            });

            modelBuilder.Entity<RankSureAyar>(entity =>
            {
                entity.ToTable("Rank_Sure_Ayar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BaslangicTar)
                    .HasColumnName("Baslangic_Tar")
                    .HasColumnType("date");

                entity.Property(e => e.IlkGunKontrol).HasColumnName("ilkGunKontrol");

                entity.Property(e => e.KacGun).HasColumnName("kac_Gun");

                entity.Property(e => e.Saat)
                    .HasColumnName("saat")
                    .HasMaxLength(5);

                entity.Property(e => e.SifirlanmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.Turu).HasColumnName("turu");

                entity.HasOne(d => d.TuruNavigation)
                    .WithMany(p => p.RankSureAyar)
                    .HasForeignKey(d => d.Turu)
                    .HasConstraintName("FK_Rank_Sure_Ayar_Rank_Tur");
            });

            modelBuilder.Entity<RankTur>(entity =>
            {
                entity.ToTable("Rank_Tur");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Turu).HasMaxLength(20);
            });

            modelBuilder.Entity<SifreDegistirme>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DegismeTarihi).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasMaxLength(50);

                entity.Property(e => e.YeniSifre).HasMaxLength(65);
            });

            modelBuilder.Entity<SiteBolumAcKapa>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.BolumAd)
                    .HasColumnName("bolumAd")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SliderResim>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ResimYol).HasMaxLength(150);
            });

            modelBuilder.Entity<TlBakiye>(entity =>
            {
                entity.ToTable("Tl_Bakiye");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CharId).HasColumnName("charID");

                entity.Property(e => e.TlBakiye1).HasColumnName("tl_bakiye");
            });

            modelBuilder.Entity<TlEpinLog>(entity =>
            {
                entity.ToTable("Tl_Epin_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.EpinId).HasColumnName("Epin_Id");

                entity.Property(e => e.HesapAdi).HasMaxLength(65);

                entity.Property(e => e.IslemTarihi)
                    .HasColumnName("Islem_Tarihi")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tur).HasMaxLength(50);

                entity.HasOne(d => d.Epin)
                    .WithMany(p => p.TlEpinLog)
                    .HasForeignKey(d => d.EpinId)
                    .HasConstraintName("FK_Tl_Epin_Log_TlSilk_Epin");
            });

            modelBuilder.Entity<TlSilkEpin>(entity =>
            {
                entity.ToTable("TlSilk_Epin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EpinKod).HasMaxLength(50);

                entity.HasOne(d => d.TuruNavigation)
                    .WithMany(p => p.TlSilkEpin)
                    .HasForeignKey(d => d.Turu)
                    .HasConstraintName("FK_TlSilk_Epin_Tl_Silk_Tur");
            });

            modelBuilder.Entity<TlSilkTur>(entity =>
            {
                entity.ToTable("Tl_Silk_Tur");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TlSilkTur1)
                    .HasColumnName("TlSilkTur")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UniquesForRank>(entity =>
            {
                entity.HasKey(e => e.MobId)
                    .HasName("PK__UniquesForRank");

                entity.ToTable("_UniquesForRank");

                entity.Property(e => e.MobId)
                    .HasColumnName("MobID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MobCode).HasColumnType("varchar(128)");

                entity.Property(e => e.MobName)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Point).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<UyeLog>(entity =>
            {
                entity.ToTable("Uye_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email).HasMaxLength(85);

                entity.Property(e => e.GizliYanit).HasMaxLength(65);

                entity.Property(e => e.HesapId)
                    .HasColumnName("Hesap_ID")
                    .HasMaxLength(65);

                entity.Property(e => e.Sifre).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });
        }
    }
}