using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DmssYazilim.OgrenciTakip.Data.OgrenciTakipMigration;
using DmssYazilim.OgrenciTakip.Model.Entities;

namespace DmssYazilim.OgrenciTakip.Data.Contexts
{
    public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext,Configuration>
    {
        public OgrenciTakipContext() //ogrenc�tak�pcontext b�z�m database�m�zd�r vede connect�on b�lg�ler�m�z� de �c�nde tas�r
        {
            Configuration.LazyLoadingEnabled = false;

        }

        public OgrenciTakipContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;//modeldek� butun ozell�kler� get�rmes�n d�ye yazd�k
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//table �s�mler�n� cogulla�t�rma yapma ayar�
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//bire �ok ili�kili tablolardak� ver�lerden b�r� s�l�n�nce d�ger�n�n s�l�nmes�n� engell�yoruz il il�e
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Okul> Okul { get; set; }
    }
}