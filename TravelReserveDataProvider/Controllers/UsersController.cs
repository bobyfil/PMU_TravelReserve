using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelReserveDataProvider.Models;
using TravelReserveCL;

namespace TravelReserveDataProvider.Controllers
{
    public class UsersController : ApiController
    {
        BusTravelEntities context;
        [HttpGet]
        public HttpResponseMessage Get(string username)
        {
            User user = null;
            using (context = new BusTravelEntities())
            {
                user = (from u in context.User where u.Username == username
                        select u).First();
            }
                 
            if (user != null)
            {
                return Request.CreateResponse<User>(HttpStatusCode.OK, user);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
    }
}
