using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace EruoOffice.Web.Repositories.Abstracts
{
    public interface ICatRepository
    {

        StringBuilder getCategoriesXml();
        StringBuilder GetImagesXml(string category);

    }
}