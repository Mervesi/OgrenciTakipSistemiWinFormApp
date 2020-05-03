using DmssYazilim.OgrenciTakip.Data.Contexts;
using System.Data.Entity.Migrations;

namespace DmssYazilim.OgrenciTakip.Data.OgrenciTakipMigration
{
    public class Configuration:DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//otomatık olarak database baglanıp gereklı gunellemelerı yapıyor
            AutomaticMigrationDataLossAllowed = true;
            //verı kaybı olması durumuna ızın ver demek-basıt olarak long'dan  int'e verı aktarırken olan kayıplar
        }
    }
}
