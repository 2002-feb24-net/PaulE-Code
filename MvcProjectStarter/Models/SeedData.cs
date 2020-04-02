using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcProjectStarter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProjectStarter.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSongContext(serviceProvider.GetRequiredService<DbContextOptions<MvcSongContext>>()))
            {
                if(context.Song.Any())
                {
                    return; //if there are already songs in the db, dont need to do anything
                }

                //else...
                context.Song.AddRange(
                    new Song
                    {
                        title = "Don't Stop Believin'",
                        genre = "Rock",
                        artist = "Journey",
                        album = "Escape",
                        ReleaseDate = DateTime.Parse("1981-3-13")
                    },

                    new Song
                    {
                        title = "Thriller",
                        genre = "Rock",
                        artist = "Micheal J",
                        album = "Thriller",
                        ReleaseDate = DateTime.Parse("1981-4-14")
                    },

                    new Song
                    {
                        title = "Eye of the Tiger",
                        genre = "Rock",
                        artist = "Survivor",
                        album = "Unknown",
                        ReleaseDate = DateTime.Parse("1985-3-13")
                    }
                    );
                context.SaveChanges();
            }

        }
    }
}
