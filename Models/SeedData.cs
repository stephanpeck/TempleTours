using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
        //This has been commented out because I am not sure whether or not it is necessary for this project. --Josh
            /*
            TourDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TourDbContext>();

            //are there any migrations that need to happen?

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //if nothing loaded in the database yet, we are going to add some info in
            if(!context.Groups.Any())
            {

                context.GroupInfo.AddRange(



                );

                context.SaveChanges();

            }
            */
        }
    }
}
