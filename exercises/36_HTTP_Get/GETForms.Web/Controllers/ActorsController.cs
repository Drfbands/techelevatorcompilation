using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class ActorsController : Controller
    { 


        private IActorDAL actorDAO;
        public ActorsController(IActorDAL actorDao)
        {
            this.actorDAO = actorDao;
        }
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var Actor = new Actor();

            return View(Actor);
        }

        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(Actor Myactor)
        {
           IList<Actor> actors = actorDAO.FindActors(Myactor.LastName);
            /* Call the DAL and pass the values as a model back to the View */
        //  actors.Results = actors;
       

            return View(actors);
        }
    }
}
