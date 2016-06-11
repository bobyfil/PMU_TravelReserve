using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelReserveDataProvider.Models;
using TraverReserveCL;
using Google.ProtocolBuffers.Serialization;

namespace TravelReserveDataProvider.Controllers
{
    public class UsersController : ApiController
    {
        BusTravelEntities context;
        [HttpGet]
        public HttpResponseMessage Get()
        {
            IEnumerable<User> users;
            IEnumerable<User> tmp;
            using (context = new BusTravelEntities())
            {
                users = (from u in context.User
                         select u).ToList();
                //if (users.Count() > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        
                        Serializer.Serialize(stream, users);
                        stream.Seek(0, SeekOrigin.Begin);
                        tmp = Serializer.Deserialize<IEnumerable<User>>(stream);
                        return Request.CreateResponse(HttpStatusCode.OK, new StreamContent(stream));
                    }
                }
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}
