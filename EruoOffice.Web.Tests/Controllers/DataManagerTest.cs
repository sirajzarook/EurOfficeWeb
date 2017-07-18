using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EruoOffice.Web.Repositories.Abstracts;
using EruoOffice.Web.Repositories;
using System.Text;
using System.Xml;

namespace EruoOffice.Web.Tests.Controllers
{
	[TestClass]
	public class DataManagerTest
	{
		[TestMethod]
		public void DM_ReadCatagories_Test()
		{
			ICatRepository _repo = new CatsRepositoryMock();
			StringBuilder output = new StringBuilder();
			output = _repo.getCategoriesXml();
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(output.ToString());

			//Action
			XmlElement root = xmlDoc.DocumentElement;
			XmlNodeList nodes = root.SelectNodes("data/categories/category"); // You can also use XPath here

			//Assert
			Assert.IsNotNull(xmlDoc);
			Assert.IsTrue(nodes.Count == 2);


		}


		[TestMethod]
		public void DM_ReadImagesForCatHat_Mocks_Test()
		{
			ICatRepository _repo = new CatsRepositoryMock();
			StringBuilder output = new StringBuilder();
			output = _repo.GetImagesXml("hats");
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(output.ToString());

			//Action
			XmlElement root = xmlDoc.DocumentElement;
			XmlNodeList nodes = root.SelectNodes("data/images/image"); // You can also use XPath here

			//Assert
			Assert.IsNotNull(xmlDoc);
			Assert.IsTrue(nodes.Count == 5);


		}

		[TestMethod]
		public void DM_ReadImagesForCatJackets_Mocks_Test()
		{
			ICatRepository _repo = new CatsRepositoryMock();
			StringBuilder output = new StringBuilder();
			output = _repo.GetImagesXml("jackets");
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(output.ToString());

			//Action
			XmlElement root = xmlDoc.DocumentElement;
			XmlNodeList nodes = root.SelectNodes("data/images/image"); // You can also use XPath here

			//Assert
			Assert.IsNotNull(xmlDoc);
			Assert.IsTrue(nodes.Count == 3);


		}

	}
}
