using MVCMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        // GET: Store
        public string Browse(string genre)
        {
            var msg = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return msg;
        }

        // GET: Store
        public string Details(int id)
        {
            var msg = "Store.Details, ID = " + id;
            return msg;
        }

        // GET: Store
        public ActionResult Albums(int id)
        {
            var albums = new List<Album>();
            for (int i = 0; i < id; i++)
            {
                albums.Add(new Album { Title = "Album" + i });
            }
            return View(albums);
        }
    }
}