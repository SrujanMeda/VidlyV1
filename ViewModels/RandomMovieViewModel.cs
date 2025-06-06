using System.Collections.Generic;
using VidlyV1.Models;

namespace VidlyV1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}