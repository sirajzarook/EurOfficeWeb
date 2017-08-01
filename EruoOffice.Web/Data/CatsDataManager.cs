using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

namespace EruoOffice.Web.Data
{
	public class CatsDataManager
	{
        /// <summary>
        /// Get list of category in XML
        /// </summary>
        /// <returns></returns>
		public StringBuilder getCategoriesXml()
		{
			var output = new StringBuilder();
			var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };

			using (XmlWriter writer = XmlWriter.Create(output, settings))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("response");
				writer.WriteStartElement("data");
				writer.WriteStartElement("categories");
				//foreach (Employee employee in employees)
				//{
				writer.WriteStartElement("category");

				writer.WriteElementString("id", "1");   // <-- These are new
				writer.WriteElementString("name", "Hats");


				writer.WriteEndElement();
				//}
				//
				writer.WriteStartElement("category");

				writer.WriteElementString("id", "2");   // <-- These are new
				writer.WriteElementString("name", "Jackets");


				writer.WriteEndElement();
				//


				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndDocument();
			}
			return output;
		}


		public StringBuilder getCategoriesSpaceSunglassesXml()
		{
			var output = new StringBuilder();
			var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };

			using (XmlWriter writer = XmlWriter.Create(output, settings))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("response");
				writer.WriteStartElement("data");
				writer.WriteStartElement("categories");
				//foreach (Employee employee in employees)
				//{
				writer.WriteStartElement("category");

				writer.WriteElementString("id", "1");   // <-- These are new
				writer.WriteElementString("name", "Hats");


				writer.WriteEndElement();
				//}
				//
				writer.WriteStartElement("category");

				writer.WriteElementString("id", "2");   // <-- These are new
				writer.WriteElementString("name", "Jackets");


				writer.WriteEndElement();
				//


				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndDocument();
			}
			return output;
		}
		public StringBuilder getHats()
		{

			var output = new StringBuilder();
			var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };

			using (XmlWriter writer = XmlWriter.Create(output, settings))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("response");
				writer.WriteStartElement("data");
				writer.WriteStartElement("images");
				//foreach (Employee employee in employees)
				//{
				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_li65qqZS6T1qcn249o1_500.gif");   // <-- These are new
				writer.WriteElementString("id", "7t9");
				writer.WriteElementString("name", "http://thecatapi.com/?id=7t9");


				writer.WriteEndElement();
				//}
				//
				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();
				//


				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndDocument();
			}

			return output;
		}


		public StringBuilder getJackets()
		{

			var output = new StringBuilder();
			var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };

			using (XmlWriter writer = XmlWriter.Create(output, settings))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("response");
				writer.WriteStartElement("data");
				writer.WriteStartElement("images");
				//foreach (Employee employee in employees)
				//{


				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();
				//


				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndDocument();
			}

			return output;
		}

		public StringBuilder getSunglasses()
		{

			var output = new StringBuilder();
			var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };

			using (XmlWriter writer = XmlWriter.Create(output, settings))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("response");
				writer.WriteStartElement("data");
				writer.WriteStartElement("images");
				//foreach (Employee employee in employees)
				//{
				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m0lr9uR2UN1qgxo86o1_500.gif");   // <-- These are new
				writer.WriteElementString("id", "ask");
				writer.WriteElementString("name", "http://thecatapi.com/?id=ask");


				writer.WriteEndElement();
				//}
				//

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m0lr9uR2UN1qgxo86o1_500.gif");   // <-- These are new
				writer.WriteElementString("id", "ask");
				writer.WriteElementString("name", "http://thecatapi.com/?id=ask");


				writer.WriteEndElement();


				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();
				//


				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndDocument();
			}

			return output;
		}

		public StringBuilder getSpace()
		{

			var output = new StringBuilder();
			var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };

			using (XmlWriter writer = XmlWriter.Create(output, settings))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("response");
				writer.WriteStartElement("data");
				writer.WriteStartElement("images");
				//foreach (Employee employee in employees)
				//{
				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://25.media.tumblr.com/tumblr_m4sk1pyS9n1qd477zo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "dhj");
				writer.WriteElementString("name", "http://thecatapi.com/?id=dhj");


				writer.WriteEndElement();
				//}
				//
				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://25.media.tumblr.com/tumblr_m4sk1pyS9n1qd477zo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "dhj");
				writer.WriteElementString("name", "http://thecatapi.com/?id=dhj");


				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://25.media.tumblr.com/tumblr_m4sk1pyS9n1qd477zo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "dhj");
				writer.WriteElementString("name", "http://thecatapi.com/?id=dhj");


				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();

				writer.WriteStartElement("image");

				writer.WriteElementString("url", "http://24.media.tumblr.com/tumblr_m1zys6olx21qgjltdo1_1280.jpg");   // <-- These are new
				writer.WriteElementString("id", "c4f");
				writer.WriteElementString("name", "http://thecatapi.com/?id=c4f");

				writer.WriteEndElement();
				//


				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndDocument();
			}

			return output;
		}
	}
}