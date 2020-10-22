using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BookingHistoryModels
    {
        [JsonProperty(PropertyName = "SeatSelected")]
        public string Selectseat { get; set; }

        [JsonProperty(PropertyName = "Fname")]
        public string Fname { get; set; }

        [JsonProperty(PropertyName = "Email")]
        public string InputEmail1 { get; set; }
    }
}