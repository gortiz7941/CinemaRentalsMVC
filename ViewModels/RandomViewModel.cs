using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CinemaRentals2.Models;

namespace CinemaRentals2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers;
    }
}