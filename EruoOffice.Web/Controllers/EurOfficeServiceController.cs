﻿using EruoOffice.Web.Repositories.Abstracts;
using EruoOffice.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Xml;

namespace EruoOffice.Web.Controllers
{
    public class EurOfficeServiceController : ApiController
    {

	private ICatRepository _repo;

	public EurOfficeServiceController(ICatRepository repository)
	{

		this._repo = repository; 
	}

	// GET: api/EuroOffApi
	[Route("api/EuroOffApi/GetCatXml")]
        public HttpResponseMessage Getxml()
        {
            var output = new StringBuilder();

			output = _repo.getCategoriesXml();

			XmlDocument doc = new XmlDocument();
			doc.LoadXml(output.ToString());

			//string XML = "<response><data><categories><category><id>1</id><name>hats</name></category></categories></data></response>";
			return new HttpResponseMessage()
            {
                Content = new StringContent(output.ToString(), Encoding.UTF8, "application/xml")
            };

        }

        // GET: api/EuroOffApi
        [Route("api/EuroOffApi/GetImagesXml/{cat}/{resultperpage}")]
        public HttpResponseMessage GetImagesxml(string cat, int resultperpage)
        {

            StringBuilder output = new StringBuilder();
			//resultperpage is not used in the example

			switch (cat.ToLower())
            {
                case "hats":
                    output = _repo.GetImagesXml(cat.ToLower());
                    break;
                default:
                    output = _repo.GetImagesXml(cat.ToLower());
                    break;
            }


            //string XML = "<response><data><categories><category><id>1</id><name>hats</name></category></categories></data></response>";
            return new HttpResponseMessage()
            {
                Content = new StringContent(output.ToString(), Encoding.UTF8, "application/xml")
            };

        }


    }
}
