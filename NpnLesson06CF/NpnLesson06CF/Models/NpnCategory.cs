using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NpnLesson06CF.Models
{
    public class NpnCategory
    {
        [Key]
        public int NpnId { get; set; }
        public string NpnCategoryName { get; set; }

        // thuộc tính quan hệ
        public virtual ICollection<NpnBook> NpnBooks { get; set; }
    }
}