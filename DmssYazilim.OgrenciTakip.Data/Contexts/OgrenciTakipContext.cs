using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DmssYazilim.OgrenciTakip.Data.OgrenciTakipMigration;
using DmssYazilim.OgrenciTakip.Model.Entities;

namespace DmssYazilim.OgrenciTakip.Data.Contexts
{
    public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext,Configuration>
    {
        public OgrenciTakipContext() //ogrencýtakýpcontext býzým databaseýmýzdýr vede connectýon býlgýlerýmýzý de ýcýnde tasýr
        {
            Configuration.LazyLoadingEnabled = false;

        }

        public OgrenciTakipContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;//modeldeký butun ozellýklerý getýrmesýn dýye yazdýk
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//table ýsýmlerýný cogullaþtýrma yapma ayarý
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//bire çok iliþkili tablolardaký verýlerden býrý sýlýnýnce dýgerýnýn sýlýnmesýný engellýyoruz il ilçe
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Okul> Okul { get; set; }
    }
}