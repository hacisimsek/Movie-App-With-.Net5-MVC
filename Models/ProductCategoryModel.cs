using System.Collections.Generic;

namespace dotnet.Models
{
    public class ProductCategoryModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}