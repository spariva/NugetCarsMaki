using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NugetCarsMaki.Models
{
    public class Airport
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }
}
