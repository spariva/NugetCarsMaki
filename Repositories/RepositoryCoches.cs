using NugetCarsMaki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NugetCarsMaki.Repositories
{
    public class RepositoryCoches
    {
        private XDocument document;


        public RepositoryCoches() {
            string resourceName = "NugetCarsPGS.coches.xml";
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(resourceName);
            this.document = XDocument.Load(stream);
        }

        public List<Coche> GetCoches() {
            var consulta = from datos in this.document.Descendants("coche") select datos;

            List<Coche> cars = new List<Coche>();
            foreach (var tag in consulta) {
                Coche coche = new Coche();
                coche.IdCoche = int.Parse(tag.Element("idcoche").Value);
                coche.Marca = tag.Element("marca").Value;
                coche.Modelo = tag.Element("modelo").Value;
                coche.Imagen = tag.Element("imagen").Value;

                cars.Add(coche);
            }
            return cars;
        }

    }
}
