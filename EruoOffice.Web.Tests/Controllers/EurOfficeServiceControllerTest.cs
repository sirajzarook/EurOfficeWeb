using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EruoOffice.Web.Repositories;
using EruoOffice.Web.Repositories.Abstracts;
using EruoOffice.Web.Controllers;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Xml;
using System.Net;
using System.Collections.Generic;

namespace EruoOffice.Web.Tests.Controllers
{
	[TestClass]
	public class EurOfficeServiceControllerTest
	{


		[TestMethod]
		public void TestMethod_ReadCategoriesFromCatsServices()
		{

			//Arrange
			var catsController = new EurOfficeServiceController();
			var actionResult = catsController.Getxml();
			var xmlDoc = new XmlDocument();
			//parse result

			StringContent strContent = actionResult.Content as StringContent;
			var xmlContent = strContent.ReadAsStringAsync();

			string xmlstring = xmlContent.Result.ToString();
			xmlDoc.LoadXml(xmlstring);

			//Action
			XmlElement root = xmlDoc.DocumentElement;
			XmlNodeList nodes = root.SelectNodes("data/categories/category"); // You can also use XPath here

			//Assert
			Assert.IsNotNull(xmlDoc);
			Assert.IsTrue(nodes.Count >= 1);



		}

		[TestMethod]
		public void TestMethod_ReadImagesFromCatsServices()
		{

			//Arrange
			var catsController = new EurOfficeServiceController();
			var actionResult = catsController.GetImagesxml("hats", 10);
			var xmlDoc = new XmlDocument();
			//parse result

			StringContent strContent = actionResult.Content as StringContent;
			var xmlContent = strContent.ReadAsStringAsync();

			string xmlstring = xmlContent.Result.ToString();
			xmlDoc.LoadXml(xmlstring);

			//Action
			XmlElement root = xmlDoc.DocumentElement;
			XmlNodeList nodes = root.SelectNodes("data/images/image"); // You can also use XPath here


			//Assert
			Assert.IsNotNull(xmlDoc);
			Assert.IsTrue(nodes.Count >= 1);


		}

		[TestMethod]
		public void TestMethod_GetCategoryXML()

		{

			//Arrange
			var m_strFilePath = "http://thecatapi.com/api/categories/list";
			string xmlStr;
			using (var wc = new WebClient())
			{
				xmlStr = wc.DownloadString(m_strFilePath);
			}
			var xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xmlStr);
			
			//Action
			XmlElement root = xmlDoc.DocumentElement;
			XmlNodeList nodes = root.SelectNodes("data/categories/category"); // You can also use XPath here
			//foreach (XmlNode node in nodes)
			//{
			//	// use node variable here for your beeds
			//}

			//Assert
			Assert.IsNotNull(xmlDoc);
			Assert.IsTrue(nodes.Count >= 1);



		}

		[TestMethod]
		public void TestMethod_GetTenHatsImagesXML()

		{

			//Arrange
			var m_strFilePath = "http://thecatapi.com/api/images/get?format=xml&amp;results_per_page=10&amp;category=hats";
			string xmlStr;
			using (var wc = new WebClient())
			{
				xmlStr = wc.DownloadString(m_strFilePath);
			}
			var xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xmlStr);

			//Action
			XmlElement root = xmlDoc.DocumentElement;
			XmlNodeList nodes = root.SelectNodes("data/images/image"); // You can also use XPath here
			//foreach (XmlNode node in nodes)
			//{
			//	// use node variable here for your beeds
			//}

																	   //Assert
			Assert.IsNotNull(xmlDoc);
			Assert.IsTrue(nodes.Count >= 1);



		}
	}
}
