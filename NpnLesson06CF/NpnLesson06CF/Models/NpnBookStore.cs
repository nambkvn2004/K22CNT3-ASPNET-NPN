using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NpnLesson06CF.Models
{
    public class NpnBookStore:DbContext
    {
        public NpnBookStore():base("NpnBookStoreConnectionString") { }

        //khai báo các thuộc tính tương ứng với các bảng trong csdl
        public DbSet<NpnCategory> NpnCategories { get; set; }
        public DbSet<NpnBook> NpnBooks { get; set; }


    }
}