using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NpnLesson06CF.Models
{
    public class NpnBook
    {
        [Key]
        public int NpnId { get; set; }
        public string NpnBookID { get; set; }
        public string NpnTitle { get; set; }
        public string NpnAuthor { get; set; }
        public int NpnYear { get; set; }
        public string NpnPulisher { get; set; }
        public string NpnPicture { get; set; }
        public int NpnCategoryId { get; set; }

        //Thuộc tính quan hệ
        public virtual NpnCategory NpnCategory { get; set; }
    }
}