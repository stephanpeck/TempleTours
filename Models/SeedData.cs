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

            TourDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TourDbContext>();

            //are there any migrations that need to happen?

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //if nothing loaded in the database yet, we are going to add some info in
            if(!context.TimeSlots.Any())
            {

                context.TimeSlots.AddRange(
                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "08:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "09:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "10:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "11:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "12:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "13:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "14:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "15:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "16:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "17:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "18:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "19:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Monday",
                        TimeSlotTime = "20:00",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "8:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "9:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "10:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "11:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "12:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "1:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "2:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "3:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "4:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "5:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "6:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "7:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Tuesday",
                        TimeSlotTime = "8:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "8:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "9:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "10:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "11:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "12:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "1:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "2:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "3:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "4:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "5:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "6:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "7:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Wednesday",
                        TimeSlotTime = "8:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "8:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "9:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "10:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "11:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "12:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "1:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "2:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "3:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "4:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "5:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "6:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "7:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Thursday",
                        TimeSlotTime = "8:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "8:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "9:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "10:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "11:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "12:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "1:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "2:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "3:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "4:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "5:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "6:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "7:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Friday",
                        TimeSlotTime = "8:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "8:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "9:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "10:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "11:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "12:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "1:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "2:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "3:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "4:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "5:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "6:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "7:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Saturday",
                        TimeSlotTime = "8:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "8:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "9:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "10:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "11:00 am",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "12:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "1:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "2:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "3:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "4:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "5:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "6:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "7:00 pm",
                        Scheduled = false
                    },

                    new TimeSlots
                    {
                        TimeSlotDay = "Sunday",
                        TimeSlotTime = "8:00 pm",
                        Scheduled = false
                    }
                );

                //Save changes to the database
                context.SaveChanges();

            }
        }
    }
}
