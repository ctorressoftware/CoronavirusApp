using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;

namespace CoronavirusApp.Models
{
    public class NoticiaParser
    {
        private string _url = "https://www.diariolibre.com/rss/actualidad.xml";

        public List<Noticia> ObtenerNoticias()
        {
            var reader = XmlReader.Create(_url);
            var feed = SyndicationFeed.Load(reader);
            var categoriaCoronavirus = "Coronavirus";
            var noticias = new List<Noticia>();

            reader.Close();

            foreach (var item in feed.Items)
            {
                foreach (var categoria in item.Categories)
                {
                    if (categoria.Name.Equals(categoriaCoronavirus))
                    {
                        noticias.Add(new Noticia
                        {
                            Titulo = item.Title.Text,
                            FechaPublicacion = item.PublishDate.DateTime,
                            Descripcion = item.Summary.Text
                        }
                        );
                    }
                }
            }

            return noticias;
        }
    }
}