using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NpnLesson06.Models
{
    public class NpnSong
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage ="Npn: Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string NpnTitle { get; set; }
        [Required(ErrorMessage ="Npn: Hãy nhập tác giả")]
        [DisplayName("Tác giả")]
        public string NpnAuthor { get; set; }
        [Required(ErrorMessage ="Npn: Hãy nhập nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Npn: Tên nghệ sĩ có tối thiểu 2 ký tự, tối đa 50 ký tự")]
        [DisplayName("Nghệ sĩ")]
        public string NpnArtist { get; set;}
        [Required(ErrorMessage ="Npn: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Npn:Năm xuất bản phải có 4 ký tự số")]
        [Range(1900,2024,ErrorMessage ="Npn: Năm xuất bản trong khoảng 1900 - 2024")]
        [DisplayName("Năm xuất bản")]
        public int NpnYearRelease{ get; set;}
    }
}