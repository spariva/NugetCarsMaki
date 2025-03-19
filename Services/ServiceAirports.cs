using NugetCarsMaki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace NugetCarsMaki.Services
{
    public class ServiceAirports
    {
        public async Task<AirportsList> GetAirportsNamesAsync() {

            WebClient client = new WebClient();

            string url = "https://services.odata.org/V4/(S(2esholowikwyef30ogqjzbvf))/TripPinServiceRW/Airports";
            string dataJson = await client.DownloadStringTaskAsync(url);

            AirportsList airports = JsonConvert.DeserializeObject<AirportsList>(dataJson);

            return airports;
        }

    }
}
