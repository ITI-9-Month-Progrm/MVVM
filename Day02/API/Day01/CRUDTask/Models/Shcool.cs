using System;
using System.Data.Entity;
using System.Linq;

namespace CRUDTask.Models
{
    public class Shcool : DbContext
    {
        public Shcool()
            : base("name=Shcool")
        {
        }
        public virtual DbSet<Student> Students { get; set; }

    }

}