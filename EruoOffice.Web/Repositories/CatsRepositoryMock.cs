using EruoOffice.Web.Data;
using EruoOffice.Web.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

namespace EruoOffice.Web.Repositories
{
    public class CatsRepositoryMock : ICatRepository
    {

        
        public StringBuilder getCategoriesXml()
        {
            var output = new StringBuilder();
			CatsDataManager data = new CatsDataManager();
			output = data.getCategoriesXml();

			return output;
        }

        public StringBuilder GetImagesXml(string category)
        {
            StringBuilder output = new StringBuilder();
			CatsDataManager data = new CatsDataManager();

            switch (category.ToLower())
            {
                case "hats":
                    output = data.getHats();
                    break;
                default:
                    output = data.getJackets();
                    break;
            }
            return output;
        }

 
    }
}