using EruoOffice.Web.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Xml;
using EruoOffice.Web.Data;

namespace EruoOffice.Web.Repositories
{
	public class CatsRepositoryMock2 : ICatRepository
	{
		public StringBuilder getCategoriesXml()
		{
			var output = new StringBuilder();
			CatsDataManager data = new CatsDataManager();
			output = data.getCategoriesSpaceSunglassesXml();

			return output;
		}

		public StringBuilder GetImagesXml(string category)
		{
			StringBuilder output = new StringBuilder();
			CatsDataManager data = new CatsDataManager();

			switch (category.ToLower())
			{
				case "hats":
					output = data.getSpace();
					break;
				default:
					output = data.getSunglasses();
					break;
			}
			return output;
		}
	}
}