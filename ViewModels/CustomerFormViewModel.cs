using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CinemaRentals2.Models;

namespace CinemaRentals2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}