﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//This is our controller. It will respond to GET, POST, DELETE...

namespace WebApplication2.Controllers
{
    public class DeviceController : ApiController
    {

        private DeviceRepository deviceRepository;

        public DeviceController()
        {
            this.deviceRepository = new DeviceRepository();
        }

        public Device[] Get()
        {
            return deviceRepository.GetAllDevices();
        }

        public HttpResponseMessage Post(Device device)
        {
            this.deviceRepository.SaveDevice(device);

            var response = Request.CreateResponse<Device>(System.Net.HttpStatusCode.Created, device);

            return response;
        }

        public HttpResponseMessage Delete(Device device)
        {
            this.deviceRepository.DeleteDevice(device);

            var response = Request.CreateResponse<Device>(System.Net.HttpStatusCode.OK, device);

            return response;
        }
    }
}
