using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication2.Models;
using WebApplication2.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class HouseController : ApiController
    {
        private HouseRepository houseRepository;

        public HouseController()
        {
            this.houseRepository = new HouseRepository();
        }

        public House[] Get()
        {
            return houseRepository.GetAllHouses();
        }

        public HttpResponseMessage Post(House house)
        {
            this.houseRepository.SaveHouse(house);

            var response = Request.CreateResponse<House>(System.Net.HttpStatusCode.Created, house);

            return response;
        }

        public HttpResponseMessage Delete(House house)
        {
            this.houseRepository.DeleteHouse(house);

            var response = Request.CreateResponse<House>(System.Net.HttpStatusCode.OK, house);

            return response;
        }
    }
}
