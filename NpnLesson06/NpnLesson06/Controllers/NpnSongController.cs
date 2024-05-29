
using NpnLesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NpnLesson06.Controllers
{
    public class NpnSongController : Controller
    {
        private static List<NpnSong> npnSongs = new List<NpnSong>() 
        { 
            new NpnSong{Id=221090047,NpnTitle="Nguyễn Phú Nam",NpnAuthor="K22CNT3",NpnArtist="NTU",NpnYearRelease=2020},
            new NpnSong{Id=1,NpnTitle="Hoàng Quốc Minh",NpnAuthor="K22CNT3",NpnArtist="NTU",NpnYearRelease=2020}
        };
      

        // GET: NpnSong
        /// <summary>
        ///    Hiển Thị danh sách bài hát
        ///    Author: Nguyễn Phú Nam
        /// </summary>
        /// <returns></returns>
        public ActionResult NpnIndex()
        {
            return View(npnSongs);
        }
        //Get: NpnCreate
        /// <summary>
        /// Form thêm mới bài hát
        /// Author:Nguyễn Phú Nam
        /// </summary>
        /// <returns></returns>
        public ActionResult NpnCreate() 
        { 
            var npnSong = new NpnSong();
            return View(); 
        }
    }
}