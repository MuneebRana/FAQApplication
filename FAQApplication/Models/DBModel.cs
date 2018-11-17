using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace FAQApplication.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class UserQuestions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int Rating { get; set; }
    }

    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=SupportDatabase")
        {
            Database.CreateIfNotExists();
            Database.SetInitializer(new DBInit());
        }
        public DbSet<FAQ> FAQ { get; set; }
        public DbSet<UserQuestions> UserQuestions { get; set; }
        

    }

}
