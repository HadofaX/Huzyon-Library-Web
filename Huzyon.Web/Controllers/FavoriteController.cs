using Microsoft.AspNetCore.Mvc;
using Huzyon.Library.Models;
using Huzyon.Library.DAL;
using System.Collections.Generic;
using System.Data;

namespace Huzyon.Web.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly FavoriteDAL favoriteDAL;

        public FavoriteController()
        {
            favoriteDAL = new FavoriteDAL();
        }

        public IActionResult Index()
        {
            List<Favorite> favorites = favoriteDAL.GetAllFavorites();
            return View(favorites);
        }
    }
}
