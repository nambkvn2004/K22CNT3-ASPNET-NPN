using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson07.Models
{
    public class NpnKetNoi:DbContext
    {
        public NpnKetNoi():base("NpnConnectionString") { }
        public DbSet<npnKhoa> npnKhoas { get; set; }
        public DbSet<npnSinhVien> npnSinhViens { get; set; }
    }
}