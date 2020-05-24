using MVCAguas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAguas.Helpers
{
    public class CombosHelper:IDisposable //IDisposable sempre para controlar o datacontext
    {
        private static MVCAguasContext db = new MVCAguasContext();

        public static List<Location> Locations()
        {
            var cities = db.Locations.ToList();
            cities.Add(new Location
            {
                AddressID = 0,
                AddressName = "{Select one city}",
            });

            return cities.OrderBy(d => d.AddressName).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}