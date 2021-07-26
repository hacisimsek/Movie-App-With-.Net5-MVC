using System.Collections.Generic;
using System.Linq;
using dotnet.Models;

namespace dotnet.Data
{
    public static class MovieRepository
    {
        private static List<Movie> movies = null;

        static MovieRepository(){
            movies = new List<Movie>(){
                new Movie()
                {
                    Id = 1 , 
                    Name = "Godzilla Vs. Kong" , 
                    ShortDescription = "Godzilla Vs. Kong", 
                    Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", 
                    ImageUrl= "1.jpg",
                    CategoryId= 1,
                },
                new Movie()
                {
                    Id = 2 , 
                    Name = "Wonder Woman 1984" , 
                    ShortDescription = "Wonder Woman 1984", 
                    Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?" , 
                    ImageUrl= "2.jpg",
                    CategoryId= 1,

                },
                new Movie()
                {
                    Id = 3 , 
                    Name = "Tom ve Jerry" , 
                    ShortDescription = "Tom ve Jerry", 
                    Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?" , 
                    ImageUrl= "3.jpg",
                    CategoryId= 2,
                },
                new Movie(){
                    Id = 4 , 
                    Name = "The Tomorrow War" , 
                    ShortDescription = "The Tomorrow War" , 
                    Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", 
                    ImageUrl= "4.jpg",
                    CategoryId= 3,
                    
                    },
                new Movie(){
                    Id = 5 , 
                    Name = "Mortal Kombat" , 
                    ShortDescription = "Mortal Kombat", 
                    Description = "" , 
                    ImageUrl= "5.jpg",
                    CategoryId= 5,
                    },
                new Movie(){
                    Id = 6 , 
                    Name = "Zack Snyder’s Justice League" , 
                    ShortDescription = "Zack Snyder’s Justice League" , 
                    Description = "" , 
                    ImageUrl= "6.jpg",
                    CategoryId= 6,
                    },
            };
        }

        public static List<Movie> Movies{
            get { return movies; }
        }
        public static void AddMovie (Movie entity){
            movies.Add(entity);
        }
        public static Movie GetById (int id){
            return movies.FirstOrDefault(i=>i.Id == id); 
        }
        
    }
}