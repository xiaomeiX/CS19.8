


namespace WebApplication6.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;



    public class HomeModel : DbContext
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
  

        public HomeModel()
            : base("name=HomeModel")
        {
        }


    }
}

   