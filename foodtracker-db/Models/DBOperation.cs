using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace foodtracker_db.Models
{
    public class DatabaseGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {   
            using (var context = new FoodtrackerDbContext(serviceProvider.GetRequiredService<DbContextOptions<FoodtrackerDbContext>>()))
            {

                context.Restorants.AddRange(
                    new Restorant
                    {
                        Name="Aspava",
                        Type="Yemek-Bar",
                        Province="Ankara",
                        District="Çankaya",
                        Establishment=new DateTime(1998,03,12)
                    },
                    new Restorant
                    {
                        Name="Dürümcü Ahmet Usta",
                        Type="Kebap",
                        Province="Ankara",
                        District="Gölbaşı",
                        Establishment=new DateTime(2002,04,21)
                    },
                    new Restorant
                    {
                        Name="Çağ Ocakbaşı",
                        Type="Ocak Başı",
                        Province="Ankara",
                        District="Kızılay",
                        Establishment=new DateTime(2010, 05, 22)
                    }
                );
                context.SaveChanges();
            }
            
        }

    }
}