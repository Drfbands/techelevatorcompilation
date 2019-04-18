using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class FilmsController : Controller
    {
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        /// 
        private IFilmDAL filmDAO;
        public FilmsController(IFilmDAL filmDao)
        {
            this.filmDAO = filmDao;
        }
        public ActionResult Index()
        {
            var film = new Film();
            return View(film);
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(Film film)
        {

            var films= filmDAO.GetFilmsBetween(film.genre, film.minLength, film.maxLength);
            film.Results = films;
            /* Call the DAL and pass the values as a model back to the View */
            return View(film);
        }
    }
}