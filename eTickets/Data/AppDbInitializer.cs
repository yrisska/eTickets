using System;
using System.Collections.Generic;
using System.Linq;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "SUN PICTURES",
                            Logo = "https://www.traveller.com.au/content/dam/images/h/0/y/9/b/x/image.related.articleLeadwide.620x349.h0y9b4.png/1526957751511.jpg",
                            Description = "Other open-air cinemas may be more more luxurious, more scenic or more romantic. But none comes close – in either charm or longevity – to the simple wooden building in the centre of Broome's Chinatown: opened in 1913, and the oldest al fresco cinema in the world. "
                        },
                        new Cinema()
                        {
                            Name = "TLC CHINESE THEATER",
                            Logo = "http://www.smh.com.au/content/dam/images/h/0/y/9/b/u/image.imgtype.articleLeadwide.620x349.png/1522802404869.png",
                            Description = "Better known as Grauman's Chinese Theater, famous for its historic Hollywood Walk of Fame, "
                        },
                        new Cinema()
                        {
                            Name = "COLOSSEUM KINO",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/f/f8/Colosseum_kino.jpg",
                            Description = "The Colosseum – built in 1921 – is one of the most memorable architectural structures in world cinema. "
                        },
                        new Cinema()
                        {
                            Name = "SCI-FI DINE-IN THEATRE",
                            Logo = "http://www.smh.com.au/content/dam/images/h/0/y/9/b/w/image.imgtype.articleLeadwide.620x349.png/1522802569618.png",
                            Description = "Sure, it's in a theme park, but it's an early example of \"retro\", designed to feel like an sanitised version of what used to go on in a classic 1950s drive-in."
                        },
                        new Cinema()
                        {
                            Name = "RAJMANDIR THEATRE",
                            Logo = "http://www.smh.com.au/content/dam/images/h/0/y/9/b/v/image.imgtype.articleLeadwide.620x349.png/1522802575221.png",
                            Description = "Wherever you are in India, reserve an afternoon to visit a Bollywood movie. However, if you happen to be in Jaipur – \"the Pink City\" with Hawa Mahal (\"Palace of the Winds\"), its jewellery shops and its Rajasthan camel rides – check out Rajmandir."
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Christian_Bale_2009.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/7/73/Chris_Tucker_by_Gage_Skidmore.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.discogs.com/caZ89uEHzQwoFhJenE-1ECExpinZtqwxhcMYJWpZdo4/rs:fit/g:sm/q:40/h:300/w:300/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9BLTg0Mzcw/Ny0xNTg4NDY3Njgx/LTc0MTIucG5n.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/1/14/Deadpool_2_Japan_Premiere_Red_Carpet_Ryan_Reynolds_%28cropped%29.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/9/92/Matthew_McConaughey_2011_AA.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Quentin Tarantino",
                            Bio = "This is the Bio of Quentin Tarantino",
                            ProfilePictureURL = "https://www.themoviedb.org/t/p/w500/1gjcpAa99FAOWGnrUvHEXXsRs7o.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Robert Zemeckis",
                            Bio = "This is the Bio of Robert Zemeckis",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTgyMTMzMDUyNl5BMl5BanBnXkFtZTcwODA0ODMyMw@@._V1_UX214_CR0,0,214,317_AL_.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Steven Spielberg",
                            Bio = "This is the Bio of Steven Spielberg",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTY1NjAzNzE1MV5BMl5BanBnXkFtZTYwNTk0ODc0._V1_UX214_CR0,0,214,317_AL_.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Mel Gibson",
                            Bio = "This is the Bio of Mel Gibson",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Mel_Gibson_Cannes_2016_2.jpg/220px-Mel_Gibson_Cannes_2016_2.jpg"
                        },
                        new Producer()
                        {
                            FullName = "George Lucas",
                            Bio = "This is the Bio of George Lucas",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/George_Lucas_cropped_2009.jpg/250px-George_Lucas_cropped_2009.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "A team of scientists aboard the International Space Station discover a rapidly evolving life form that caused extinction on Mars and now threatens all life on Earth.",
                            Price = 39.50,
                            ImageURL = "https://xl.movieposterdb.com/21_04/2017/5442430/xl_5442430_65544e4b.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Django Unchained",
                            Description = "With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
                            Price = 29.50,
                            ImageURL = "https://xl.movieposterdb.com/21_02/2012/1853728/xl_1853728_7fb18a9f.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Avengers: Endgame",
                            Description = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                            Price = 39.50,
                            ImageURL = "https://xl.movieposterdb.com/21_09/2019/4154796/xl_4154796_2b869564.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/A1KlensOW1L._AC_SL1500_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Forrest Gump",
                            Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                            Price = 39.50,
                            ImageURL = "https://xl.movieposterdb.com/05_06/1994/0109830/xl_21293_0109830_af6ba7a1.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Ready Player One",
                            Description = "When the creator of a virtual reality called the OASIS dies, he makes a posthumous challenge to all OASIS users to find his Easter Egg, which will give the finder his fortune and control of his world.",
                            Price = 39.50,
                            ImageURL = "https://xl.movieposterdb.com/20_06/2018/1677720/xl_1677720_376c9e0b.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                    context.SaveChanges();
                }
                //Actor & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
